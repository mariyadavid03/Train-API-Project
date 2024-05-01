<?php
    session_start();
    $selectedClass = isset($_POST['selectedClass']) ? $_POST['selectedClass'] : '';
        $trainID = $_GET['trainID'];
        $scheduleID = $_GET['scheduleID'];

    if (isset($_POST['txtNic'])) {
        $_SESSION['txtNic'] = $_POST['txtNic'];
    }


?>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Seat Booking</title>
    <link rel="stylesheet" href="CSS/seat.css">
</head>
<body>
    <header>
        <div class="top">
            <h2 class="heading"><center>Booking</center></h2>
        </div>
    </header>
    <a href="index.php" class="button-back">Back</a>
    <div class="container">
        <form action="" method="post" id="bookingForm">
            <div class="seat-container">
            <table>
                <tr>
                    <td style="padding-right: 21px;">Select Class</td>
                    <td>
                    <select name="txtClass" id="txtClass">
                        <option value="">-- Select Train Class --</option>
                        <option value="First Class" <?php echo ($selectedClass == 'First Class') ? 'selected' : ''; ?>>First Class</option>
                        <option value="Second Class" <?php echo ($selectedClass == 'Second Class') ? 'selected' : ''; ?>>Second Class</option>
                        <option value="Third Class" <?php echo ($selectedClass == 'Third Class') ? 'selected' : ''; ?>>Third Class</option>
                    </select>
                    <br>
                    </td>
                </tr>

                <!-- Retiving Class when selected -->
                <script>
                    document.addEventListener('DOMContentLoaded', function() {
                    const selectClass = document.getElementById('txtClass');
                    selectClass.addEventListener('change', function(event) {
                        event.preventDefault(); 
                        const selectedClass = selectClass.value;
                        console.log('Selected Class:', selectedClass);
                        document.getElementById('selectedClass').value = selectedClass;
                        console.log('Hidden field value:', document.getElementById('selectedClass').value);
                            setTimeout(function() {
                                document.getElementById('bookingForm').submit();
                            }, 100);
                        });
                    });
                </script>
                <div>
                <input type="hidden" id="selectedClass" name="selectedClass" value="<?php echo htmlspecialchars($selectedClass); ?>">
                
                <?php
                    if(isset($_POST['selectedClass'])){
                        $selectedClass = $_POST['selectedClass'];

                        $classNameEncoded = urlencode($selectedClass);
                        $totalSeatsUrl = "https://localhost:44387/api/Class/TotalSeats?trainId=$trainID&className=$classNameEncoded";
                        $contextOptions = array(
                            "ssl" => array(
                                "verify_peer" => false,
                                "verify_peer_name" => false
                            )
                        );
                        $context = stream_context_create($contextOptions);
                        $json = file_get_contents($totalSeatsUrl, false, $context);
                        
                        $totalseats = json_decode($json);
                       
                        if (is_numeric($totalseats)) {
                            $totalSeatsNumber = intval($totalseats);
                            $bookedSeatNumbersUrl = "https://localhost:44387/api/Seat/GetBookedSeatNumbers?trainId=$trainID&className=$classNameEncoded";
                            $contextOp = array(
                                "ssl" => array(
                                    "verify_peer" => false,
                                    "verify_peer_name" => false
                                )
                            );
                            
                            $con = stream_context_create($contextOp);
                            $jsn = file_get_contents($bookedSeatNumbersUrl, false, $con);
                            $bookedSeatNumbers = json_decode($jsn);

                            //Counting Avalable Seats
                            if (is_array($bookedSeatNumbers)) {
                                    $numBookedSeats = count($bookedSeatNumbers);
                                    $availableSeatCount = $totalseats - $numBookedSeats;
                                
                            } else {
                                $availableSeatCount = 0;

                            }
                        } else {
                            $availableSeatCount = 0;
                            
                        }
                    }
                ?>
                        <?php 
                            if (isset($_POST['selectedClass'])) {
                                if (isset($availableSeatCount)) {
                                    echo '<tr style="background: #e0ffcd;margin-bottom: 10px;padding: 10px 3px 7px 1px;">';
                                    echo '<td style = "padding-left: 79px;">Available Seats</td>';
                                    echo '<td>';
                                    echo ($availableSeatCount > 0) ? $availableSeatCount : "Full";
                                    echo '</td>';
                                    echo '</tr>';
                                } else {
                                    echo '<tr style="background: #e0ffcd;margin-bottom: 10px;">';
                                    echo '<td colspan="2" style="display: block;text-align: center;padding: 11px 3px 0px 1px;">Please select a class</td>';
                                    echo '</tr>';
                                }
                            } else {
                                echo '<tr style="background: #e0ffcd;margin-bottom: 10px;">';
                                echo '<td colspan="2" style="display: block;text-align: center;padding: 11px 3px 0px 1px;">Please select a class</td>';
                                echo '</tr>';
                            }
                        ?>
                <tr>
                    <td style="padding-right: 27px;">Select Seat</td>
                    <td>
                        <select name="txtSeatNo" id="">
                        <?php
                           if($totalseats != null && $availableSeatCount > 0){
                            $allSeatNumbers = range(1, $totalseats);
                            $bookedSeatNumbersArray = array_map('intval', $bookedSeatNumbers);
                            $availableSeatNumbers = array_diff($allSeatNumbers, $bookedSeatNumbersArray);
                            foreach ($availableSeatNumbers as $seatNumber) {
                                echo '<option value="' . $seatNumber . '">' . $seatNumber . '</option>';
                            }
                           }else{
                            echo '<option value="">No seats available</option>';
                           }
                            
                        ?>
                        
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>Passenger NIC</td>
                    <td><input type="text" name="txtNic" id="" value="<?php echo isset($_SESSION['txtNic']) ? htmlspecialchars($_SESSION['txtNic']) : ''; ?>" maxlength="12"></td>
                </tr>
            </table>
            <center>
            <input clas="btn" type="submit" value="Book Now" name="btnBook" style="padding: 5px 10px;font-size: 13px;background: rgb(21, 153, 235);color: white;border: none;border-radius: 5px;cursor: pointer;">
            </center>    
        </div>
        </form>
        <?php 
            if(isset($_POST['btnBook'])){
                $nic = $_POST["txtNic"];
                $seatNo = $_POST["txtSeatNo"];
                $class = $_POST["txtClass"];

                //Checking NIC usage
                $url = "https://localhost:44387/api/Booking/check/$nic/$trainID/$scheduleID";
                $curl_ = curl_init($url);
                curl_setopt($curl_, CURLOPT_SSL_VERIFYPEER, false);
                curl_setopt($curl_, CURLOPT_SSL_VERIFYHOST, false);
                $response_ = curl_exec($curl_);
                
                $httpCode = curl_getinfo($curl_, CURLINFO_HTTP_CODE);
                if ($httpCode != 200) {
                    echo '<script>alert("Booking limit exceeded for this passenger");';
                    echo 'window.location.href = "summary.php";</script>';
                    
                }
        
                curl_close($curl_);
                $_SESSION['txtNic'] = $nic;
                
                $bookingUrl = "https://localhost:44387/api/Booking";
                $seatUrl = "https://localhost:44387/api/Seat";
                
                $bookingdata = array(
                    'trainId' => $trainID,
                    'scheduleId' => $scheduleID,
                    'className' => $class,
                    'seatNo' => $seatNo,
                    'passengerNIC' => $nic
                );

                $seatdata = array(
                    'seatNo' => $seatNo,
                    'className' => $class,
                    'trainId' => $trainID,
                    'seatStatus' => "Booked"
                );
            
                $postData = json_encode($bookingdata);
                $postData2 = json_encode($seatdata);
            
               // cURL session for booking
                $curl = curl_init();
                curl_setopt($curl, CURLOPT_URL, $bookingUrl);
                curl_setopt($curl, CURLOPT_POST, true);
                curl_setopt($curl, CURLOPT_POSTFIELDS, $postData);
                curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
                curl_setopt($curl, CURLOPT_HTTPHEADER, array(
                    'Content-Type: application/json',
                    'accept: */*'
                ));
                curl_setopt($curl, CURLOPT_SSL_VERIFYPEER, false);
                curl_setopt($curl, CURLOPT_SSL_VERIFYHOST, false);
                $response1 = curl_exec($curl);
                curl_close($curl);

                // cURL session for seat booking
                $curl2 = curl_init();
                curl_setopt($curl2, CURLOPT_URL, $seatUrl);
                curl_setopt($curl2, CURLOPT_POST, true);
                curl_setopt($curl2, CURLOPT_POSTFIELDS, $postData2);
                curl_setopt($curl2, CURLOPT_RETURNTRANSFER, true);
                curl_setopt($curl2, CURLOPT_HTTPHEADER, array(
                    'Content-Type: application/json',
                    'accept: */*'
                ));
                curl_setopt($curl2, CURLOPT_SSL_VERIFYPEER, false);
                curl_setopt($curl2, CURLOPT_SSL_VERIFYHOST, false);
                $response2 = curl_exec($curl2);
                curl_close($curl2);

                if ($response1 !== false && $response2 !== false) {
                    echo '<script>';
                        echo 'if(confirm("Booking added successfully. Book again using the same NIC?")) {';
                        echo 'window.location.href = window.location.href;';
                        echo '} else {';
                        echo 'window.location.href = "summary.php";'; 
                        echo '}';
                    echo '</script>';
                } else {
                    echo "Booking Adding Failed";
                }
              curl_close($curl);
            }
        ?>
    </div>
    
</body>


</html>