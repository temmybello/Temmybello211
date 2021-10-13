Feature: Login
    In order for me to use the website 
	I need to login 

@mytag
Scenario: Admin Login
	Given I Navigate to Website https://opensource-demo.orangehrmlive.com/
    And I need to Login as Admin
    And I Click on Admin
    And I Click on Qualifications
    And I 	Click on Skills
    And I  Click on Add
    And  I Enter the skill name
    And I Enter Description
    When I Click on Save
    Then I Confirm the skill as been successfully added


	