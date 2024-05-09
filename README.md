# AutomationTest02-DealsDray - Functional Testing
The Functional Test of the DealsDray Test.

I have written the code using Nunit using Page Object Model for keeping the WebElements and methods related to that separately making the code structured. POM can increase the code maintainability, reusability, and readability.
This Repository has the Scripts, Videos, Screenshots, and Failures of the Automation Tests 

Automation Test 02 - Functional Tests 
The File Upload is unable to automate as the file "input" HTML tag of the "Choose File" link is not working and is considered an invalid argument when used in the code. The XPath for the input tag does not work.
So, I used the div tag //*[@id='root']/descendant::div[contains(@class,'css-uodm64')] to get the Choose File Link to work. But, it will not upload the file due to the input tag being invalid

I have added the Screenshots of the input tag that causes the failure of execution and the step where it failed and the video of the execution.

The below File has marked the input tag which is considered an invalid argument. Due to this, file upload is not working

![Screenshot of the failure reason](https://github.com/keerthikwarrier/AutomationlTest02-DealsDray/assets/13638900/1238e864-bb01-4daf-b04c-c4fdf750e1b3)

The below file shows the step of clicking the ChooseFile Link

![ScreeshotofClickingFileUpload](https://github.com/keerthikwarrier/AutomationlTest02-DealsDray/assets/13638900/658ed335-39c8-487f-8e3f-af8da732af70)

The below file shows the FileUpload Window Opening but cannot upload the file

![ScreenshotFileNotUploading](https://github.com/keerthikwarrier/AutomationlTest02-DealsDray/assets/13638900/1cd44da3-7c28-474a-9c98-ad0c21d7fad7)

DealsDrayVideo - Login and FileUpload Video : 

https://github.com/keerthikwarrier/DealsDray-AutomationlTest02-FunctionalTesting/assets/13638900/b4df005a-c92d-4da8-a744-8c5d1a7ec9eb



keerthikwarrier/DealsDray-Automation-Tests
