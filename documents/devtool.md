#	ScomDevTool
## Overview
* ScomDevTool defines SECS Messages, and it also generates message definitions. In this section, describes how to use ScomDevTool to define structure of messages and generate SMD information.
* ScomDevTool is a SECSEdi tor to edit a SECS messages.

## ScomDevTool Window

![image](https://user-images.githubusercontent.com/102704655/161019497-8c997c7c-ecc2-41cb-96ed-b9e24c80ba61.png)


## ScomDevTool Menu Bar
* The ScomDevTool menu bar provides the following menus.
* The Project menu provides you to manage project files. 
* The Edit menu provides you to edit SECS message structure items. For details, see [‘Editing SECS Message Definitions’](#editing-secs-message-definitions) section.
* The View menu provides you to change the property of SECS Message Definition Pane and choose SECS Message Library. For details, see ['Loading SECS Message Libraries’](#loading-secs-message-libraries) section
* The Build menu provides you to generate SECS Message Definitions File (SMD).
* The Help menu provides the information of ScomDevTool.


## ScomDevTool Toolbar
 ![image](https://user-images.githubusercontent.com/102704655/161019552-eb214193-ec2d-46f0-a2e1-b41f4f710d88.png)
* The ScomDevTool’s toolbar provides a row of icons for initiating common procedure, as follows:
* ![image](https://user-images.githubusercontent.com/102704655/161019582-34338197-92d6-45d5-8476-f956bdbed936.png)
 New Project - Creating a new project. For details, see ['Craeting a New Project’](#creating-a-new-project) section.
* ![image](https://user-images.githubusercontent.com/102704655/161020071-36a17036-421a-402e-bbc7-4dac472eedcf.png)
 Open Project – Opening a project. For details, see [‘Opening a Project’](#opening-a-project) section.
* ![image](https://user-images.githubusercontent.com/102704655/161171047-4ec8407a-ef37-469c-98a6-8538e2f8f984.png)
  Save Project – Saving a project. For details, see [‘Saving a Project’](#saving-a-project) section.
* ![image](https://user-images.githubusercontent.com/102704655/161171091-e9acd1c1-4661-4bdd-9d96-d1f798206db6.png)
  Cut – Cut message that is part of the selected SECS message
* ![image](https://user-images.githubusercontent.com/102704655/161171126-e538da2f-754b-45dc-9fbb-3205ca009b08.png)
  Copy – Copy message that is part of the selected SECS message.
* ![image](https://user-images.githubusercontent.com/102704655/161171199-42136c3e-0e8d-48f8-a3d3-f04e95c998c5.png)
  Paste Next – Paste the copied message below the selected SECS message. 
* ![image](https://user-images.githubusercontent.com/102704655/161171395-66a5441d-0c7f-4c54-8bc3-8ac686dce4a3.png)
  Find – Enter values to search for items
* ![image](https://user-images.githubusercontent.com/102704655/161171404-c3a43038-2576-43e1-8466-3db2328aa464.png)
  Build SECS Message Definitions – Generating SECS Message Definitions file (SMD).

## Creating a New Project
#### Choose Project ->New
* If you have a project currently open, a following dialog asks if you want to save the current project.

![image](https://user-images.githubusercontent.com/102704655/161171473-352f8c2e-39fe-47c7-b022-6f7fea6eebd4.png)


* If you click ‘Yes’, ScomDevTool save the current project before creating a new project
* If you click ‘No’, ScomDevTool does not save the current project.
* If you click ‘Cancel’, ScomDevTool cancel the ‘New Project’ command and return to current project.

## Assign new Project Name
 
 ![image](https://user-images.githubusercontent.com/102704655/161171799-888829db-6328-460d-9876-060df5357d8b.png)


* If a ‘New Project’ dialog opens, enter project name in the ‘Project Name’ textbox and select project type and project path.

#### Create new Project Environment
* If you click ‘OK,, ScomDevTool create a new project environment. (For details, see [‘Project Environment’](#project-environment) section.)

## Opening a Project 
#### Choose Project ->Open
* If you have a project currently open, a dialog asks if you want to save the current project. (For details, see ['Creating New Project’](#creating-a-new-project) section.)

#### Select Project
* If you select a ScomDevTool’s project file from an ‘Open Project’ dialog, ScomDevTool reads an assigned project file and prepares an environment for a project.
 
 ![image](https://user-images.githubusercontent.com/102704655/161171847-0e2286e7-4596-4906-a061-29c98814fed0.png)


## Saving a Project
#### To save the current project under the same name: Choose Project ->Save
* ScomDevTool saves the project under the current project name.

#### To save the current project under a new name: Choose Project ->SaveAs
* A ‘SaveAs Project’ dialog opens, type a new project name in the ‘Project Name’ box and choose OK button. 
* ScomDevTool saves the project under a new name.
 
 ![image](https://user-images.githubusercontent.com/102704655/161171902-604944cc-b967-4a5b-9355-22024dbc5529.png)


## Project Environment
* You can store ScomDevTool project files in any directory. In each project directory, however, ScomDevTool creates the followings.

#### Project Directory
* ScomDevTool creates project directory with project name, and saves project file (‘ProjectName.sdt’) in current location.

#### ‘ScomInfo’ Directory
* It contains SECS Message Definitions (‘ProjectName.smd’) file.

## ScomDevTool SECS Message Editor
#### Overview
* You use ScomDevTool’s SECSEditor to define the structure of SECS Messages used by the equipment you want to control.
In this section, describes how to use SECSEditor to define SECS Messages.

#### SECSEditor Window

![image](https://user-images.githubusercontent.com/102704655/161172442-bdef4822-3269-4330-984b-a03f2491c3b7.png)

 
#### SECS Message Editing Pane

![image](https://user-images.githubusercontent.com/102704655/161172448-d1244ffe-159c-43bd-be4f-1b7b8b7bf6ef.png)

* The ‘SECS Message Editing Pane’ enables you to modify the header items of SECS message.
* In the ‘Message Definition Editing Pane’, use the following controls to handle the header

![image](https://user-images.githubusercontent.com/102704655/161172476-c71a6452-8b52-49ee-b853-8c7b3dd0d4a1.png)


#### SECS DataItem Editing Pane

![image](https://user-images.githubusercontent.com/102704655/161172494-da3fa554-eef3-4a04-882d-1d86a880f35a.png)

* The ‘SECS DataItem Editing Pane’ enables you to edit individual items in the body of a SECS message. 
* In the ‘SECS DataItem Editing Pane’, use the following controls to alter the item

![image](https://user-images.githubusercontent.com/102704655/161172559-da7cac9a-13e7-4e0d-82fc-af18467eb1fb.png)

#### SECS Message Library Pane
 
 ![image](https://user-images.githubusercontent.com/102704655/161172597-8d9b2538-8154-4878-8c0f-47c83e8d99ab.png)

* The ‘SECS Message Library Pane’ displays the contents of message definitions of current selected library and provides several ways to choose and import individual message definitions into the current project.

#### SECS Message Definition Pane

![image](https://user-images.githubusercontent.com/102704655/161172602-f99560b2-e4b6-44eb-afbe-9e8f5f2a2aaf.png)

* The ‘SECS Message Definition Pane’ displays the definition of every message imported into the current project.
* To edit a message definition, you select the parts of the definition that you want to change in this pane, and edit it by using the ‘SECS Message Editing Pane’ and the ‘SECS DataItem Editing Pane’.
* In this pane, you can cut, copy, and paste individual lines of message definitions or entire message definitions by using Edit Menu and Pop-Up menu.

#### Loading SECS Message Libraries
###### SECSEditor loads the Standard SECS-II Library by default when it runs first. You can load other libraries, including ones that you have defined yourself, to use the ‘SECS Message Library’ command in the ‘View’ menu. You can switch to the SECS Standard library or import custom message definition files.
###### You can load one of the following message definition libraries into SECSEditor:
* AIM SEMI Standard Library, which contains the entire message currently defined in the SECS-II standard.
* AIM GEM Standard Library, which contains the SECS-II messages currently included in the GEM standard.
* AIM SECS Message Definition File, which contains messages defined using ScomDevTool’s SECSEditor (SMD)

#### Editing SECS Message Definitions
###### Defined SECS Message Format
 
 ![image](https://user-images.githubusercontent.com/102704655/161172758-6ce15a3f-fe08-4341-a705-689e46f8a4f5.png)

##### Message Header
* The message header consists of a description of the message’s name and function, followed by a single line providing information in the following format:
###### MessageName: Sn Fm Wait-Flag AutoReply-Flag Direction
###### MessageName: Message name. (ASCII format)
###### Sn Fm: Stream and Function numbers of the message.
###### Wait-Flag: The letter ‘W’ indicates that the message interpreter must wait for a secondary message after sending this primary message.
###### AutoReply-Flag: If SECS message includes the string ‘<R>’, ScomDriver replies the secondary message automatically when the primary message is received. 
###### Direction: Message transmission direction. This field can have three types.
* ‘H → E’	Host to equipment
* ‘H ← E’	Equipment to host
* ‘H ←→ E’	Both direction

##### Message Body
* SECSEditor displays the body of message definition using the SECS-II tree structure format used in the Book of SEMI Standard 1996, Equipment Software, Volumn1.

## Editing SECS Message Definitions
#### 1)	Importing SECS Messages
① You can import message definitions into your current project by selecting what you want from the currently loaded message definitions library and add them to the list displayed in the SECS Message Definition Pane. Also you can define your own messages and import them using the SECS Message Editing Pane.
 
②	To import definitions using the SECS Message Library Pane
Click the desired definition in the SECS Message Library pane, drag the selected definition over to the SECS Message Definition pane, and drop them there.
 
③	To add definitions using the SECS Message Editing pane
Enter the desired definition in the SECS Message Editing pane, and click ‘Add’ button. SECSEditor add the message definition to the end of displayed definitions list in the SECS Message Definitions Pane. (For details, see ‘3.3.2.1.SECS Message Editing pane’ section.)

####	2) Editing Message Header
① Select the desired definition in SECS Message Definition pane, and click on the definition’s header.
 
②	In the SECS Message Editing Pane, edit properties of definition. (For details, see ‘3.4.1.3.SECS Message Editing pane’ section)
 
③	Click ‘Change’ button. SECSEditor updates the message definition in the SECS Message Definition pane.

#### 3)	Editing Message Body
*	To add a new message body.
 
①	If you want to add the new item definition to the end of defined items in the message body, click the right button on the header of the desired message definition in the SECS Message Definition pane, then select ‘Insert Item’ or ‘Add Child Item’ menu on the popup. (If you select a not-list typed item, SECSEditor disables ‘Add Child Item’ menu)
 
②	If you want to insert the new item definition in the list of defined items in the message body, click the right button on a specified item of the desired message definition in the SECS Message Definition pane, then select ‘Insert Item’ or ‘Add Child Item’ menu on the popup.
 
③	If you select ‘Insert Item’ menu, a new SECS DataItem will be added as sibling. If you select ‘Add Child Item’ menu, a new SECS DataItem will be added as a child.
 
④	After adding a new SECS DataItem, you should edit it in the SECS DataItem Editing Pane.

*	To edit a message body.
①	Select the desired definition in SECS Message Definition pane, and click the desired item in the message definition body.
 
②	SECSEditor displays the current settings for the item in the SECS DataItem Editing Pane.
 
③	Edit properties of item in the SECS DataItem Editing pane and SECSEditor updates the message definition in the SECS Message Definition pane directly.

##	Building Definitions
####	Overview
###### This section describes how to build definitions on the basis of the SECS.
###### You use these outputs (SMD) to implement Equipment Interface Program.

####	SECS Message Definitions
###### ScomDriver uses a file called SMD (SECS Message Definitions) to check the validity of SECS Messages exchanged with the equipment.

###### To generate this SMD File, choose ‘Build->SECS Message Definition’ menu.
###### Then ScomDevTool will generate the XML formatted SECS Message Definitions file and store it in the current project directory.
