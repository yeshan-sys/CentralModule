Feature: CustomerCreation
	This Regression Testing for 
	Central Module

@Creation
Scenario Outline:1. Create a Business Partner
	Given I navigated to Login page
	And I have entered username <username> and password <password>	
	When I press login  button 
	Then Navigate to Customer Registration
	And I filled the Basic informations <nic>, <date>, <firstName>, <middleName>, <lastName>, <placeOfBirth>		
	Then I filled and added the <addFirst>, <addSec>, <addThird> Contact Information <TelNo>		
	And I filled and added the comman tab <km>, <m>, <cost> data			
	And I add a Attachment <attachment>
	When I clicked on the save button
	Then Saved DB data is displayed <nic> 		
	When I navigated to WorkBench
	Then Verify the workflow data <nic>	
	And Logout from the system
Examples: 
	| username | password | nic        | firstName | middleName | lastName    | placeOfBirth | date       | addFirst | addSec   | addThird | TelNo       | km | m   | cost | attachment                                                           |
	| chamikay | $RFV4rfv | 933594230V | chanaka   | lakmal     | Weerasekara | Matara       | 12/06/2020 | 123B     | Kohuwela | Kurunda  | 07178451263 | 3  | 300 | 2000 | C:\\Users\\chamikay\\Pictures\\Screenshots\\ProductCreation\\abc.png |

@UpdateCustomer
Scenario Outline:2. Update a Business Partner
	Given I navigated to Login page
	And I have entered username <username> and password <password>	
	When I press login  button 
	Then Navigate to Customer Inquiry page   
	And Search for a business partner to update <nic>
	And I Updated name <firstName>, <middleName>, <lastName> and Place of birth <placeOfBirth>	
	Then I Updated the business partner address and  <addFirst>, <addSec>, <addThird>, changed Contact Information <TelNo>	
	And I added a new transport detail <km>, <m>, <cost> data			
	And I added a Attachment <attachment>
	When I clicked on the save button for Update business partner		
	When I navigated to WorkBench Incompleted Activities
	Then Verify the Workflow data for updated business partner <nic>  
	And Logout from the system
Examples: 
	| username | password | nic        | firstName | middleName | lastName | placeOfBirth | addFirst | addSec    | addThird | TelNo      | km | m   | cost | attachment                                                           |
	| chamikay | $RFV4rfv | 933594225V | Bhanuk    | Sandaruwan | Perera   | Matara       | JENNY    | PAMBURANA | PALLAWA  | 0413325158 | 1  | 200 | 5000 | C:\\Users\\chamikay\\Pictures\\Screenshots\\ProductCreation\\abc.png |
	
@UpdateCustomerApproval
Scenario Outline:3. Approve the Updated business Partner 
	Given I navigated to Login page
	And I have entered username <username> and password <password>	
	When I press login  button 
	Then Navigate Workbench to approve the Updated Business Partner 
	And Verify the Updated Business Partner Details in Approvals tab of Workbench <nic>
	Then Approve the Updated Business Partner <comment>
	Then Verify the Business Partner Details in Completed Activities <nic>
	And Verify the DB updated data of Updated Busines Partner <nic>
	And Logout from the system
Examples: 
	| username | password	| nic        | comment         |
	| qaoic1   | qaz@123	| 933594225V | Automation Test |	

@UpdateCustomerCompletedActivities
Scenario Outline:4. Verify Completed Activities Details
	Given I navigated to Login page
	And I have entered username <username> and password <password>		
	When I press login  button 
	When I navigated to WorkBench
	Then Verify the Business Partner Update Details in Completed Activities <nic>
	And Logout from the system

Examples: 
	| username | password | nic        | 
	| chamikay | $RFV4rfv | 933594225V | 

@CompanyCreation
Scenario Outline:1. Create a Company
	Given I navigated to Login page
	And I have entered username <username> and password <password>	
	When I press login  button 
	Then Navigate to Company Registration
	And I filled the Basic informations of Company Registration <br>, <name>, <othername>	
	Then I filled and added the Contact Details of Company <address1>, <address2>, <address3>, <telNo>		
	And I filled and added the comman details of Company <nic>, <description>, <shares>, <voting>		
	And I add a Attachments for Company <brAttachment>
	When I Saved the Company
	Then Saved Date is displayed for Company <br>		
	When I navigated to WorkBench
	Then Verified that Comapny DB data in Completed Activities of Workbench <br>	
	And Logout from the system
Examples: 
	| username | password | nic        | br		    | name          | othername | address1 | address2   | address3 | telNo       | description    | shares | voting | brAttachment                                                         |
	| chamikay | $RFV4rfv | 933594225V | MA/AA/1002 | KASUN TRADERS | JOHN      | 123B     | Kohuwela   | Kurunda  | 07178451263 | SECOND OFFICER  | 30     | 90     | C:\\Users\\chamikay\\Pictures\\Screenshots\\ProductCreation\\abc.png |

@StatusMaintenance
Scenario Outline:5. Change the Business Partner Status
	Given I navigated to Login page
	And I have entered username <username> and password <password>	
	When I press login  button 
	Then Navigate Status Maintenance
	And Search business partner for Change the status <nic>
	Then Change the business partner status <description>, <attach>
	And save the data of changed status
	Then Verify the Business Partner details in Incompleted Workbench <nic>
	And Logout from the system
Examples: 
	| username	 | password  | nic        | description	      | attach                                                               |
	| chamikay   | $RFV4rfv  | 933594225V | Test Automation   | C:\\Users\\chamikay\\Pictures\\Screenshots\\ProductCreation\\abc.png |

@StatusApproval
Scenario Outline:6. Approve the Status Changed Business Partner
	Given I navigated to Login page
	And I have entered username <username> and password <password>	
	When I press login  button 
	Then Navigate Workbench to approve the status changed Business Partner 
	And Verify the Business Partner Details in Approvals tab of Workbench <nic> 
	Then Approve the status changed Business Partner <comment>
	And Navigate to Completed Activities
	Then Verify Completed Activities <nic>
	And Verify the DB Business Partner staus <nic>
	And Logout from the system
	
Examples: 
	| username | password | nic        | comment         | 
	| qaoic1   | qaz@123  | 933594225V | Test Automation | 

@StatusCompletedActivities
Scenario Outline:7. Verify Completed Activities Details
    Given I navigated to Login page
	And I have entered username <username> and password <password>		
	When I press login  button 
	When I navigated to WorkBench
	Then Verify Completed Activities <nic>
	And Logout from the system

Examples: 
	| username | password | nic        | 
	| chamikay | $RFV4rfv | 933594225V | 

@NoteMaintenance
Scenario Outline:8. Add a Note for a Business Partner
	Given I navigated to Login page
	And I have entered username <username> and password <password>	
	When I press login  button 
	Then Navigate Note Maintenance
	And Search for a Business Partner for add a Note <nic>
	Then Add the Note for the Business Partner <note>
	And Verify the DB for newly added note of Business Partner <nic> 
	Then Navigate to Customer Inquiry page   
	And Search for a business partner to update <nic>
	And Logout from the system
Examples: 
	| username   | password  | nic        | note                                |
	| chamikay   | $RFV4rfv  | 933594225V | Add a new Note for Business Partner |


