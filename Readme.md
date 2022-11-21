Build Instructions
1. Edit the spreadsheet of the hotels you want to add and add info to all the fields
2. Download a CSV of the file - https://docs.google.com/spreadsheets/d/1KLiGpCEtGy9q2KAOe0W4wVCTQhmMmrjn84ogOrKoMlQ/edit#gid=0 
3. Git clone the HotelParser app - https://github.com/jbaker00/HotelParser.git 
4. Copy the Downloaded file over to the same directory as the Hotel Parser app and rename to HotelList.csv
    1. $$TODO$$ Or edit the hotel parser app to point to the defaulted download file name in the defaulted download directory
        1. And if you do comit and sync the changes back up to GIT
5. $$TOTDO$$ (automate this) Delete the header row out of the CSV
6. Run the Hotel Parser app (after compiling)
7. GIt Clone the Xcode project ResortBrowser - https://github.com/jbaker00/ResortBrowser
8. Copy the output1.txt over to the ResortBrowser file RecipieModel.swift to replace that file 
9. Delete last comma at the bottom of the RecipieModel.swift
10. Increase the version number of the app under settings
11. Compile/Run the App
    1. Fix errors if they happen
12. Test out the app
    1. Make sure every resort has a picture and description and website link
    2. Make sure the descriptions match the right resorts and there were no typos in the XLS that may have messed up
    3. Make sure the categories have what’s expected in them
13. Compile the app as Archive
14. Commit the changes to git for Resort Browser
15. Deploy the app to developer portal as an app
16. Open the build on developer.apple.com
17. Add in the fact that the application does not use encryption
18. Go to TestFlight tab
19. Add the beta users you want to add
20. Wait till app clears the first review
21. Submit for app review to publish to store
