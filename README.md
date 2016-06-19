Rpasswordchanger:
=================
This is useful for organisation which are on Microsoft active directory(AD) domain controllers.
One of the problem system administrator face is they are not able to change the local admin
password of the desktops of the users.
There are two issue when local admin passwords are not changed regularly
- organisation which have implemented some kind of GRC have to change the local admin
passwords at least once a quarter/monthly. There is no straight forward method to do this.
- some insider attackers may crack the hash of local admin and use this to install their own set of
software, which can lead to data stealing/information compromise from the local network.

Installing Rpasswordchanger:
---------------------------
Please download and install the following dependencies before you install Rpasswordchanger

* Dot Not 4 (https://www.microsoft.com/en-in/download/details.aspx?id=17718)
* SQLCE https://www.microsoft.com/en-in/download/details.aspx?id=1787
* Rpasswordchanger: http://securityresearch.cysecurity.org/RPCSetup.zip

Using Rpasswordchanger:
=========================
Get Computers List Tab:
--------------------------
Two ways to load computers list:
* You can load from computer list from a text file(separated by new line).:
* Click “Browse” button to select the file.
* Once the list is loaded, it will take you to the “Change Password” tab.
* Retrieve from Active Directory(AD):
* Enter Domain Name, AD Server IP address and Credentials.
* Click “Get Computer List”
* Once it retrieved the computer list from AD, it will take you to the “Change
Password” tab.Change Password Tab:
With AD username and password, you can change the local administrator accounts.
* Choose the computers which you want to change the password.
* If you want to choose all the computers from the list, click the checkbox on the top.
* Enter AD Credentials and Domain Name(on the right side) and click the "Set" Button
* Select whether you want to change the Default admin account("Administrator") or all
local admin accounts of the desktop machines connected to the AD.
* Click Change Password Button
* Once password changing process is completed, you can see the new password list in
"View Passwords" tab
Other Functions:
* You can export the passwords list to a CSV file by Right clicking on the "View Passwords"
tab
* In “Change Password Tab”: You can enable or disable computers from the list - These
computers will be ignored when doing password change.
* In “Change Password Tab”: If you want to disable password change on the computer
from the list, you can select the computer and click disable button.
* In “Change Password Tab”: If you want to enable the computer from the list, you can
select the computer and click enable button.
* In “Change Password Tab”: If you want to remove the computer from the list, you can
select the computers and click Remove button.
