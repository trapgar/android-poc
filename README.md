# android-poc
Proof of concept for an Xamarin Android project

## Instructions
See below for how to create an Xamarin Android app that references a library that can be referenced by any other .NET project. That relationship will allow you to develop game logic against the library instead of Android directly, so we have a clear separation of UI and implementation. Additionally, if you ever choose to create a desktop or web app, you can reference the same game logic lib and won't have to duplicate any unnecessary code.

1. Download VS 2019 Community (https://visualstudio.microsoft.com/downloads/)
2. Make sure when prompted, you install the "Mobile development with .NET" module

![vs-2019-community-install](/tutorial/vs-2019-community-install.png)

3. Launch VS 2019 and select "Tools>Android>Android SDK Manager..."

![vs-2019-android-sdk](/tutorial/vs-2019-android-sdk.png)

4. If it prompts you for a repair, click 'Yes', 'Agree', etc.
5. Also make sure you have the matching SDK version of your Android phone selected. If not, select it and click "Apply".
    - You can view your phone's Android version under "Settings>System>About" (this varies by manufacturer so may be different for you).
6. While in your phone, also enable Developer Mode. Again, this varies by manufacturer, but it's usually tapping the version number 5 or 7 times.
7. Plug your phone into your computer via USB, making sure that debugging mode is enabled.
8. Go back to VS 2019 and click "File>New>Project".
9. Select "Android App (Xamarin)"

![vs-2019-create-android-project](/tutorial/vs-2019-create-android-project.png)

10. Choose project name, file location, etc. You will also be prompted for app type and version. I'd recommend "Navigation Drawer App". The version MUST match your phone's Android version!
11. Click "File>New>Project" and add a "Shared Project" to the solution (make sure it's the C# one and not the Visual Basic one).

![vs-2019-create-shared-project](/tutorial/vs-2019-create-shared-project.png)

12. Again prompted for project name and location. This is going to be the project that houses all the application agnostic game logic, so I'd name accordingly.
    - Also make sure you select "Add to solution" instead of "Create new solution".
14. To add the Shared project as a reference to the Android project, Right+Click on each project in the 'Solution Explorer' and select "Add>Reference...", then expand "Shared Projects" and select your Shared project.

![vs-2019-ref-shared-project](/tutorial/vs-2019-ref-shared-project.png)
