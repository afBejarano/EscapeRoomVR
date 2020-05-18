# Escape Room VR 🎮🎮

### Description

This is a testbed to conduct psychological training through games. It seeks to collect data from users while the user is having fun, solving 3 puzzles. Thanks to an immersive environment (through VR) and the use of the "Escape Room" game type, users will be motivated to follow our test.

It is important to note that it is for users 13 years and older.


![](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/demo.png)


[🎮 See video - demo!!! 🎬🎥🎮](https://youtu.be/mbAbzxoia-Y)

**Do not watch this video if you will do the test**


## How to test

You will be guided by voice to solve 3 puzzles that requires to move objects in a room. This will take you about 10 minutes. We will collect anonymous data of the actions you take in the game, in the end we will ask you to fill a form, which will take you about 5 minutes. You will require a space of about 3x3 meters (or 10 x 10 ft.).

If you agree to follow this test continue to these steps:

1. Sideload the APK into the Oculus Quest:
   * Using Powershell (_You must have installed adb_):
   
      Open PowerShell in the folder where the APK is and use the following command:
      
      > adb install -r .\English.apk
      
      You should see a successful install message like this one:
      
      ![](/Docs/ps.png)
   * Using SideQuest:
      
      Open SideQuest App
      ![](/Docs/sidequest1.png)
      
      Drag and drop the apk in the SideQuest app
      ![](/Docs/sidequest2.png)
      
      Wait until the installation is completed
      ![](/Docs/sidequest3.png)
      
2. Open the game in the Oculus: Library -> Unknown sources -> PsicoTests2x2English. Please stand more or less in the middle of the room to start the game.

3. In the VR environment, you can see a timestamp on the wall to the right. This is your ID. Please remember it or don't close the test until you have used this number for the next survey as it will be needed to analyze the data of your test.

4. After having tested the software, please fill the following Google Form. This will take you around 5 minutes and will help us understand what we did right and what we did wrong, alongside collecting some data we need for this experiment. Thank you for your participation and have a great day.

Google Form: [Link here](https://forms.gle/ahx28H3LDYGFm18h7)

## How to modify the test code

### Prerequisites

- [Git Bash](https://git-scm.com/downloads)
- [Unity Hub](https://unity3d.com/es/get-unity/download)
- [Unity](https://unity3d.com/es) (this project was developed using Unity.2019.2.5f1)
- [Android](https://developer.android.com/studio)

### Instructions

#### * If you have not Unity 2019.2.5f1 installed 

1. Install [Unity Hub](https://unity3d.com/es/get-unity/download)
2. Search the Unity 2019.2.5f1 version
![Search Unity](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/unityHubvers201925.PNG)
3. Select the build configurations with SDK and NDK
![Configs SDKNDK](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/installUnitySDKNDK.PNG)

#### * If you have Unity 2019.2.5f1 installed 

1. Install Unity, you can pay or use the Personal version (https://store.unity.com/download?ref=personal)
2. Install the Android SDK, or  the Android IDE (which includes the SDK). In this URL you can do it https://developer.android.com/studio
3. Using the Android IDE we need install the tools, like ndk, adb, etc. For this, you need follow this pictues that explain the configuration and instalation:

![Android Configurations](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/0.PNG)
![Settings1](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/sett1.PNG)
![Settings2](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/sett2.PNG)
![EVWindow](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/finallsett.PNG)

_

Too see the routes of SDK, JDK and JRE

![Project structure](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/1.PNG)
_

![Routes](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/2.PNG)


### Create the Environment variables:
5. Found "Environment variables" with Windows search.
6. This will open the following window, in which you must to click in "Environment variables".

![EVWindow](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/search.PNG)

7. Create the variables like is showed in the next picture (the route can change with your system username,in my case is Vivian, but please verify this)

![Variables](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/variables.PNG)

8. Open Unity > Edit > Preferences > External tools, and insert the same route of the Environment variables:

![Routes](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/5.PNG)

9. Open your git bash console in the directory of your Unity Projects (see the route in the IDE)

![GitBash](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/gibash.PNG)

10. Clone the project using your Git bash console, in this way:
```
git clone  https://github.com/VivianGomez/BottlesShooter-
```
11. Whith the project BoottlesShooter downloaded, please click on File > Open Project, and open the folder of the project

### To run  the project using your Oculus Go device.
12. Conect the Oculus Go to your PC using the USB cable
13. Click on File > Build and Run, and verify that you have the following configuration

![BR](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/buildandRun.PNG)

**Note:** If you do not have able the Android Plattaform, you must dowload it from Unity page or the assistant of Unity show to you a download button in the same window of Build and Run.

14 Activate the VR configuration at the same window:
![VR](https://raw.githubusercontent.com/VivianGomez/BottlesShooter-/master/Tutorial/VR.PNG)

**Note**: If you need more explanation about the VR and Oculus configuration, use this [official guide](https://developer.oculus.com/documentation/unity/latest/concepts/book-unity-gsg/)

16. When you have the same configuration of the picture and your Oculus Quest on Developer mode, you can click on Build and run, and wait that the app be executed on your conected device.


### Oculus Quest Developer mode:

To begin development locally for Oculus Quest, you must enable Developer Mode in the companion app. Before you can put your Oculus Quest in Developer Mode, you need to have created (or belong to) a developer organization on the Oculus Dashboard.

To join an existing organization:

1. You’ll need to request access to the existing organization from the admin.
2. You’ll receive an email invite. Once accepted, you’ll be a member of the Organization.

To create a new organization:

1. Go to: https://dashboard.oculus.com/organizations/create/
2. Fill in the appropriate information.

Enable Developer Mode

Then, to put your Oculus Quest in developer mode:

   1. Open the Oculus app on your mobile phone.
   2. In the Settings menu, select the Oculus Quest headset that you’re using for development.
   3. Select More Settings.
   4. Toggle Developer Mode on.
   
**Note**: If you need more explanation about the Oculus Quest Developer mode configuration, use this [official guide](https://developer.oculus.com/documentation/quest/latest/concepts/mobile-device-setup-quest/)



