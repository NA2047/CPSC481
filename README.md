# Trail Explorers
- CPSC 481 (Human-Computer Interaction I) - Project Repository
- WPF Application for Microsoft Windows

# Description
This is an interaction design project for a hiking application that caters to both novice and experts users.

# Stack
- C#
- Microsoft Visual Studio

# Requirements
- Make sure you are running the Windows operating system in order to run the application
- Download the latest version of [Visual Studio](https://visualstudio.microsoft.com/downloads/)

# Deployment
In order to the run the application, follow the instructions:
- Open the `CPSC_481_Trailexplorers.sln` file using Visual Studio
- Once the project has launched, click on `Build` dropdown menu and select `Build Solution`
- One the code has been compiled, navigate to the following directory `../CPSC_481_Trailexplorers/bin/Debug`
- Click on the `CPSC_481_Trailexplorers.exe` file and launch the application

# Team Members
- Andrew Garcia-Corley
- Logan Pearce
- Muhannad Nouri
- Wish Vishaal Bakshi
- Zachary Hull

# Walkthrough
### Scenario A
- The novice user launches the application, and selects the `Help` button to receive a walkthrough of the application in order to find a trail most suitable for them.
- The user is greeted with the `Filter` screen with a variety of differenty trail properties to select from.
- Next, from the dropdown menu the user selects `Province` Alberta and `Park` Banff National Park.
- In addition, the user picks easy for `Difficulty` and anything that has `Time` up to 4 hours in duration, while maxing out the `Distance` slider, and `Elevation` up to 2.
- Finally, the user selects the `Apply` button and is taken to the following screen.
- The user is shown a list of available trails matching the requirements they set in the previous screen.
- The user decides to select on `Big Beehive` as it seems the most interesting, and the screen transitions to the trail `Profile` page.
- In the `Profile` page, the user scans all available information and clicks on the `Click For Map` button to be redirected to Google Maps for driving directions to the trailhead.

### Scenario B
- The expert user launches the application, and selects the `Let` button to in order to immediately receive a list of all available trails to them.
- Since the expert user needs no introduction, they are given the ability to `Search` for the trail they are looking for at the top of the screen.
- The user enters the trail they are searching for (e.g. `Cory Pass`) and the search results in that specific trail being displayed in the list-view.
- The user decides to select on `Chester Lake` as it is what they're searching for, and the screen transitions to the trail `Profile` page.
- In the `Profile` page, the user scans all available information and clicks on the `Directions Here` button to be redirected to Google Maps for driving directions to the trailhead.

### Scenario C
- The novice user launches the application, and selects the `Help` button to receive a walkthrough of the application in order to find a trail most suitable for them.
- The user is greeted with the `Filter` screen with a variety of differenty trail properties to select from.
- Next, from the dropdown menu the user selects `Province` British Columbia and `Park` Yoho National Park.
- In addition, the user picks easy for `Difficulty` and anything that has `Time` up to 2.5 hours in duration, while selecting `Distance` to be 5.5, and `Elevation` up to 3.
- Finally, the user selects the `Apply` button and is taken to the following screen.
- The user is shown a list of available trails matching the requirements they set in the previous screen.
- The user decides to select on `Emerald Basin` as it seems the most interesting, and the screen transitions to the trail `Profile` page.
- In the `Profile` page, the user scans all available information and clicks on the `Click For Map` button to be redirected to Google Maps for driving directions to the trailhead.
