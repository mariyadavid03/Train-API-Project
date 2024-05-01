<?php
    session_start();
    $trainId = $_SESSION['train_id'];
    $nic =  $_SESSION['txtNic'];
    $type = $_SESSION['train_type'];
    $trainNO = $_SESSION['train_no'];
    $trainName = $_SESSION['train_name'];
    $startTime = $_SESSION['start_time'];
    $endTime = $_SESSION['end_time'];
    $startStation = $_SESSION['start'];
    $endStation = $_SESSION['end'];
    $date = $_SESSION['date'];
    $scheduleId = $_SESSION['schedule_id'];

    $url = "https://localhost:44387/api/Booking/PassengerSeats?passengerNIC=$nic&trainId=$trainId&scheduleId=$scheduleId";
    $contextOptions = array(
        "ssl" => array(
            "verify_peer" => false,
            "verify_peer_name" => false
        )
    );
    $context = stream_context_create($contextOptions);
    $json = file_get_contents($url, false, $context);
    $seats = json_decode($json);

?> 
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Booking Summary</title>
    <link rel="stylesheet" href="CSS/summary.css">
</head>
<body style="background: rgb(21, 153, 235);">
    <div class="container">
        <h2>Booking Summary</h2>
        <table>
            <tr>
                <td>Train No</td>
                <td style="font-weight: 600;"><?php echo $trainNO?></td>
            </tr>
            <tr>
                <td>Train Name</td>
                <td style="font-weight: 600;"><?php echo $trainName?></td>
            </tr>
            <tr>
                <td>Type</td>
                <td style="font-weight: 600;"><?php echo $type?><br></td>
            </tr>
            <tr>
                <td>Start Station</td>
                <td style="font-weight: 600;"><?php echo $startStation?></td>

                <td>End Station</td>
                <td style="font-weight: 600;"><?php echo $endStation?></td>
            </tr>
            <tr>
                <td>Departure Time</td>
                <td style="font-weight: 600;"><?php echo $startTime?></td>

                <td>Arrival Time</td>
                <td style="font-weight: 600;"><?php echo $endTime?></td>
            </tr>
        </table>
        <div class="info">
            <h4>Date</h4>
            <label><h3><?php echo $date?></h3></label>
            <h4>NIC</h4>
            <label><h3><?php echo $nic?></h3></label>
            <h4>Seats</h4>
            <label><h3 = style="margin-left: 38%;">
                <?php 
                    foreach($seats as $seat){
                        echo '<label><h5>'
                                .$seat->seatNo.' - '.$seat->className.
                              '</h5></label>';
                    }
                ?>
            </h3></label>
        </div><center>
        <a href="session.php" style="padding: 5px 10px;background-color: rgb(21, 153, 235);text-decoration: none;color: white;">Return</a>
        </center>
    </div>
    
</body>
</html>