# README #
This brings a new Send E-mail Action for Sitecore 9 Forms, enabling the submission of e-mails using MainUtil.SendMail method, which will use an SMTP server to submit e-mails in HTML or Plain Text. When a Send E-mail Action is added to a button in a Form, an E-mail Template has to be selected - this is where the E-mail is configured. 

# Installation #
1. Download last packages from
https://bitbucket.org/nishtechinc/formssendmail/src/c746250215d2d5c4a5bdfcfbeafa914b3edd3e50/Packs/?at=master
    2. Package 1 - Sitecore 9 Forms - Send Email Action-1.x.zip - All files and items needed for the Send E-mail Action
    3. Package 2 - Sitecore 9 Forms - Test Send Email Form-1.x.zip - Test Send E-mail Form for quick testing the form
4. Install Package 1 to have the Action installed
5. (Optional) Install Package 2 to have the Test Send-Email Form
6. Setup your SMTP server by editing /App_Config/Include/smtp.config and modify it to your SMTP server. Default values will use localhost a port 25, which is good for development with a tool such as SMTP4DEV (https://archive.codeplex.com/?p=smtp4dev)
    1. <setting name="MailServer" set:value="localhost"/>
    1. <setting name="MailServerUserName" set:value=""/>
    1. <setting name="MailServerPassword" set:value=""/>
    1. <setting name="MailServerPort" set:value="25"/>
7. Publish + Reindex

# Configurations #
### E-mail Templates ###
* Create E-mail Templates under /sitecore/system/Settings/Forms/E-mail Templates - This is the root folder of the "Select E-mail Template" dialog that appears when the Send E-mail Action is added to a form.
    * You can MOVE this folder to anywhere at the Database. The reference to it is setup to this Item ID at core:/sitecore/client/Applications/FormsBuilder/Components/Layouts/Actions/SendEmail/PageSettings/ItemTreeView 
Check the TDS item at https://bitbucket.org/nishtechinc/formssendmail/src/c746250215d2d5c4a5bdfcfbeafa914b3edd3e50/TDS.Core/sitecore/client/Applications/FormsBuilder/Components/Layouts/Actions/SendEmail/PageSettings/ItemTreeView.item?at=master&fileviewer=file-view-default
    * If you want to use another folder item with a different ID, you have to adjust the item above to point to your new ID
* Fill up field Subject, From, To, Cc, Bcc and either Message RichText or Message Text
* Add Keywords using the syntax {FieldName} in all of these fields to have them being replaced with data typed by the user at the Form
* If a Send E-mail Action is attached to a Form and linked to a correct template, when the form is submitted it will send an e-mail with the parsed E-mail Template using the SMTP server setup at SItecore.

### Dictionary Items ###
Dictionary items used at this Action are stored under the Default Global Dictionary of Sitecore, at path /sitecore/system/Dictionary/Forms/Actions/SendMail. You can move these Dictionary Entries to any other Dictionary if you want, and also modify their Texts, just make sure you don't change their Keys so the code can find them.

### Test Send Email Form ###
If you installed the second package and want to use the Test Send E-mail Form, make sure to add an MVC Form Rendering (/sitecore/layout/Renderings/System/Forms/Mvc Form) to a placeholder in a page. After that, you can Preview the item with the Test Form and submit to have the E-mail message being sent. 

# What is this repository for? #
* Implemenetation of Sitecore 9 Forms - Send E-mail Action
* Documentation of the action implementation
* Release of Sitecore Packages under https://bitbucket.org/nishtechinc/formssendmail/src/c746250215d2d5c4a5bdfcfbeafa914b3edd3e50/Packs/?at=master

### Who do I talk to? ###
* Rodrigo Peplau - rpeplau@nishtechinc.com
