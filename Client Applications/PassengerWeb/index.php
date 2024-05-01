<?php
session_start();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Booking Home</title>
    <link rel="stylesheet" href="CSS/booking.css">
</head>
<body>
    <header>
        <div class="top">
            <h2 class="heading"><center>Booking</center></h2>
        </div>
    </header>
    <div id="container" style="width: fit-content;height: fit-content;display: flex; margin-left: auto; margin-right: auto;margin-top: 49px;">
        <form action="" method="post">
            <table>
                <tr>
                    <td>Select Date:</td>
                    <td><input type="date" name="txtDate" id=""></td>
                </tr>
                <tr>
                    <td>Start Station:</td>
                    <td><input type="text" name="txtStartStation" id=""></td>
                </tr>
                <tr>
                    <td>End Station:</td>
                    <td><input type="text" name="txtEndStation" id=""></td>
                </tr>
                <tr>
                    <td></td>
                    <td style="text-align-last: end; margin-top:10px;">
                        <button class="btn" type="submit" name="btnSearch" style="color: white;">Search</button>
                    </td>
                </tr>
            </table>
        </form>
    </div>

    <br>
    <div class="train">
        <div class="train-data-view">
            <?php
                if (isset($_POST['btnSearch'])) {
                    if (empty($_POST['txtDate']) || empty($_POST['txtStartStation']) || empty($_POST['txtEndStation'])) {
                        echo '<p style="color: red; text-align: center;">Please enter data in all fields</p>';
                    }
                    $startStation = $_POST["txtStartStation"];
                    $endStation = $_POST["txtEndStation"];
                    $date = $_POST["txtDate"];
                    $formattedDate = date("m-d-Y", strtotime($date));

                    //API Connection
                    $url = "https://localhost:44387/api/Schedule/schedules?date=$formattedDate&startStation=$startStation&endStation=$endStation";
                    $contextOptions = array(
                        "ssl" => array(
                            "verify_peer" => false,
                            "verify_peer_name" => false
                        )
                    );
                    $context = stream_context_create($contextOptions);
                    $json = @file_get_contents($url, false, $context);
                    $results = json_decode($json);

                    
                    if (empty($results)) {
                        echo '<p style="color: red; text-align: center;">No results found</p>';
                        exit();
                    }
                    foreach ($results as $schedule) {
                        $trainID = $schedule->trainId;

                        //Retrieving Train
                        $trainUrl = "https://localhost:44387/api/Train/$trainID?id=$trainID";
                        $con = stream_context_create($contextOptions);
                        $jsn = file_get_contents($trainUrl, false, $con);
                        $trainInfo = json_decode($jsn);
                        echo '<table>';
                        echo '<tr> 
                                <th> Train No </th>
                                <th> Name </th>
                                <th> Type </th>
                                <th> Action </th>
                            </tr>';
                        if (is_object($trainInfo)) {
                            echo '<tr>';
                                echo '<td>' . $trainInfo->trainNo . '</td>';
                                echo '<td>' . $trainInfo->trainName . '</td>';
                                echo '<td>' . $trainInfo->trainType . '</td>';
                                echo '<td> <input type="button" value="Select" class="btnSelect" data-train-id="' . $trainID . '"> </td>';
                                echo '<input type="hidden" name="trainDeparture" value="' . $schedule->startTime . '">';
                                echo '<input type="hidden" name="trainArrival" value="' . $schedule->arrivalTime . '">';

                                //storing in session
                                $_SESSION['train_type'] = $trainInfo->trainType;
                                $_SESSION['train_no'] = $trainInfo->trainNo;
                                $_SESSION['train_name'] = $trainInfo->trainName;
                                $_SESSION['start_time'] = $schedule->startTime;
                                $_SESSION['end_time'] = $schedule->arrivalTime;
                                $_SESSION['start'] = $startStation;
                                $_SESSION['end'] = $endStation;
                                $_SESSION['date'] = $date;
                                $_SESSION['train_id'] = $trainID;
                                $_SESSION['schedule_id']= $schedule->scheduleId;

                            echo '</tr>';
                        }
                    }

                    echo '</table>';
                }
            ?>
        </div>
        <div class="train-info-display" data-train-id="<?php echo $trainID ?>"style="display: none;">
            <h4><center>Train Info</center></h4>
            <div class="info">
                <div class="labels">
                    <label>Departure Time</label>
                    <label>Arrival Time</label>
                </div>
                <div class="info-display">
                <?php
                        echo '<label>' . $schedule->startTime . '</label>'; 
                        echo '<label>' . $schedule->arrivalTime . '</label>'; 
                ?>
                </div>
            </div>
            <center><br><a href="seat_selecting.php?trainID=<?php echo $trainID ?>&scheduleID=<?php echo $schedule->scheduleId ?>">Book a Seat</a></center>

        </div>
    </div>
    
    <script>
        document.addEventListener('DOMContentLoaded', function() {
            const selectButtons = document.querySelectorAll('.btnSelect');
            selectButtons.forEach(button => {
                button.addEventListener('click', () => {
                    const trainID = button.dataset.trainId;
                    const trainInfoDisplay = document.querySelector('.train-info-display[data-train-id="' + trainID + '"]');
                    trainInfoDisplay.style.display = 'block';
                });
            });
        });
    </script>
    
    
</body>

</html>