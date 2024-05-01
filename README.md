# Train API

This repository is an API development project done for a coursework module "Service Oriented Architecture" for a railway station along with client applications for seat booking (Website) and train & schedule management (Windows Form Applciation)

## Features

- **Train Management**: Add, remove, update, and view train details.
- **Schedule Management**: Create, update, and view schedules for trains.
- **Seat Booking (Web Client)**: Allows users to browse trains and book seats via a web interface.
- **Train and Schedule Management (WinForms Client)**: Provides a desktop application for train operators to manage trains and schedules efficiently.

## Installation

### Prerequisites
- SQL Server: Ensure that Microsoft SQL Server is installed and running.
- Visual Studio: Required to run the API and WinForm applications.
- Visual Studio Code: Required for running wen client.

### Steps

1. Clone this repository to your local machine.
2. Navigate to the API-Project directory (API-Project -> API -> RailwayAPI).
3. Open the solution in Visual Studio Code
4. Run the API Application
5. For the seat booking web client, navigate to the `PassengerWeb` directory and run the application in Visual STudion Code.
   (API Project -> Client Applications -> PassengerWeb)
8. For the train and schedule managing WinForms client, open the `RailwayController` solution file in Visual Studio and run the application.
   (API Project -> Client Applications -> RailwayController)

## Usage

### API Endpoints

- **/booking**
  - POST: Add new booking
  - GET: Get all bookings
  - GET (BookingId): Get booking by ID
  - GET (PassengerNIC, TrainID, ScheduleID): Checking for NIC usage
  - GET (PassengerNIC, TrainID, ScheduleID): Get all seats booked by one NIC
  - DELETE: Remove a booking

- **/class**
  - POST: Add new train class
  - GET: Get all train classes
  - GET (ClassID): Get class by ID
  - GET: Get total seats
  - PUT (ClassID): Update class details
  - PUT (ClassName, TrainID): Update schedule details
  - DELETE: Remove a train

- **/schedule**
  - POST: Add new schedule
  - GET: Get all schedules
  - GET (ScheduleID): Get the schedule by ID
  - GET (Date, StartStation, EndStation): Get schedules of a date
  - GET: Get all start station
  - GET: Get all end stations
  - PUT: Update schedule details
  - DELETE: Remove a schedule

- **/seat**
  - POST: Add new seats
  - GET: Get all seats
  - GET (SeatId): Get seat by ID
  - GET (TrainID, ClassName): Get booked seat numbers
  - PUT: Update seat details
 
- **/train**
  - POST: Add new train
  - GET: Get all trains
  - GET (TrainId): Get train by ID
  - PUT: Update train details
  - DELETE: Delete train

Refer to the API documentation for detailed usage instructions.

### PassengerWeb (Web Client)

- Open the web client application in your browser.
- Enter the date, start station and end station.
- Browse available trains and schedules.
- Book seats for desired schedules.

### TrainControllerApp(WinForms Client)

- Launch the WinForms application.
- Select schedule or train management
- Manage train details and schedule details efficiently through the user interface.

