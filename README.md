# AutomationTest02-DealsDray
The Functional Test of the DealsDray Test
This Repository has the Scripts, Videos,Screenshots and the Failures of the Automation Tests 

Automation Test 02 - Functional Tests 
The File Upload is unable to automate as the file "input" HTML tag of the "Choose File" link is not working and is considered an invalid argument when used in the code. The XPath for the input tag does not work.
So, I used the div tag //*[@id='root']/descendant::div[contains(@class,'css-uodm64')] to get the Choose File Link to work . But, it will not upload the file due to the input tag being invalid

I have added the Screenshots of input tag which causes the failure of execution and the step where it failed and the video of the execution. File Names are as below,

This below File has marked the input tag which is considered an invalid argument. Due to this, file upload is not working

![Screenshot of the failure reason](https://github.com/keerthikwarrier/DealsDray-Automation-Tests/assets/13638900/48009d14-966e-44e0-85d6-469282c034dd) 

This below file shows the step of clicking the ChooseFile Link

![ScreeshotofClickingFileUpload](https://github.com/keerthikwarrier/DealsDray-Automation-Tests/assets/13638900/6e0de510-26e3-49e1-8234-9128478192e7) 

This below file shows the FileUpload Window Opening but cannot upload the file

![ScreenshotFileNotUploading](https://github.com/keerthikwarrier/DealsDray-Automation-Tests/assets/13638900/764ed095-8acc-47f7-9ef8-b1cf571ad460) 

DealsDrayVideo - Login and FileUpload Video : 

https://github.com/keerthikwarrier/DealsDray-Automation-Tests/assets/13638900/235473bc-5a91-42ae-b393-66b8478e9000

keerthikwarrier/DealsDray-Automation-Tests
