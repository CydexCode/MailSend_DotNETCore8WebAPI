# MailSend_DotNETCore8WebAPI

A simple .NET Core 8 Web API project to send emails with attachments using MailKit and MimeKit.

## Features

- Send emails with subject and body
- Attach multiple files to the email
- Configurable SMTP settings


## How This Works
- SendMailController.cs: The controller that handles HTTP POST requests to the /SendMail endpoint. It receives email details and attachments via a multipart/form-data request.
- MailSendService.cs: The service that constructs the email message using MimeKit, attaches files if provided, and sends the email using MailKit's SMTP client.
- appsettings.json: Configuration file that holds SMTP server settings such as email, password, host, and port.
- Program.cs: The entry point of the application which configures services and middleware.

## API Endpoint

Send Email
- Endpoint: POST /SendMail

- Description: Sends an email with the specified details and attachments.

Request:

- Content-Type: multipart/form-data
Body:
- ToEmail: Recipient email address
- Subject: Email subject
- Body: Email body (HTML supported)
- Attachments: List of files to be attached  

## Swagger Interface

- Post method 

  <img src="./images/img1.png" width="500" height="320" />


- Add Informations

  <img src="./images/img2.png" width="500" height="320" />


- Response
  

  <img src="./images/img3.png" width="500" height="320" />



  <img src="./images/img4.png" width="500" height="320" />


### Need a Star for this Repository ⭐
