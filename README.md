# CodeGenerator
Following are some hints to make changes in Code Generator

## Updation in cshtml generation 
###### 1. Changes in using statements or initObject
 - update resource initialResourceCode from htmlGeneratorResource.resx file.

###### 2. Changes in div tag for angular controller
 - update resource tagDivControllerStart from htmlGeneratorResource.resx file.
 - update GenerateCshtmlString function in CshtmlGenerator class accordingly.

###### 3. Changes in Crud nav bar
 - update resource tagDivToolBar from htmlGeneratorResource.resx file.

###### 4. Changes in client side error pop up
 - update resource tagDivErrors from htmlGeneratorResource.resx file.

###### 5. Changes in Form tag
 - update resource tagFormStart from htmlGeneratorResource.resx file.
 - update GenerateCshtmlString function in CshtmlGenerator class accordingly.

###### 6. Changes is specific control
 - Title:     Function: GetTitleString     Resource: fieldTitle
 - Textbox:   Function: GetTextboxString   Resource: fieldTextBox
 - TextArea:  Function: GetTextAreaString  Resource: fieldTextArea
 - Dropdown:  Function: GetDropdownString  Resource: fieldDropdown
 - Lookup:    Function: GetLookupString    Resource: fieldLookup
 - Date:      Function: GetDateString      Resource: fieldDateMonth
 - Time:      Function: GetTimeString      Resource: fieldTime
 - Number:    Function: GetNumberString    Resource: fieldNumber
 - Grid:      Function: GetGridString      Resource: fieldTitle
