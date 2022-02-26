# AutomatedRoutine &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/LendritIbrahimi/AutomatedRoutine/blob/main/LICENSE)

AutomatedRoutine is a .NET application for automating user actions such as mouse movement and key presses.

* **Flexible:** Building with different components allows you to create an unlimited number of unique routines.
* **Efficient:** With minimal memory usage, AutomatedRoutine can execute routines indefinitely.
* **Save & Load Routines:** Save your current routine to a file and load them at any time.

## Usage

The purpose of this application is making repetive tasks automated.

Following a simple UI, creating a routine is as simple as adding the nessesary instructions and pressing the "Start" button.

![Running Example](https://drive.google.com/uc?export=view&id=11vRdBc8jyRB8pqGmItFKwIldEMgvamNt)

### Steps

To add an instruction click the "+ Add Another" button.

Currently the available instructions are:
* **Move Mouse:** Moves the cursor to the given X and Y position.   
    - Incremental: 
      If unchecked, the mouse moves to the given X and Y pixel on the screen.
      If checked, the mouse moves by X and Y pixels from its initial position.
    - Duration: How long should the mouse travel to reach the given position given in miliseconds.
* **Click Mouse Button:** Simulates a left or right mouse click.
* **Scroll Mouse Wheel:** Simulates a mouse wheel scroll by a given distance.
* **Press Key:** Simulate a key press or multiple keys pressed at the same time.
* **Write Text:** Simulate sequential key presses to write the given text.
* **Wait For Time:** Wait for a given time until the next instruction continues.

![Steps Example](https://drive.google.com/uc?export=view&id=11ENbwK7gXDnTmDSKt_8TzJ36uMVwEPhM)



### Repetitions

Allows the user to configure how many times the instructions should be repeated.

Possible configurations are:
* **Number of Repetitions:** The instructions will be repeated for the exact number of times given. 
* **Infinite:** The instructions will be repeated until the stop button is pressed or the application is closed.
* **Time-Based (In Development):** The instructions will be repeated until the given time. 
 
![Second Example](https://drive.google.com/uc?export=view&id=1RsXNVGgFGHCvNcnIswKIZLibqwktcH8R)

### Extensions

Allows the user to configure the default time to wait between instructions, this removes the need for unnessesary "Wait" instructions.



## Contributing

This project is still in development.

Contributions and suggestions are welcomed!

### License 

AutomatedRoutine is [MIT licensed](./LICENSE).
