<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWorkPage.aspx.cs" Inherits="Cloud_Poe_PartOne.MyWorkPage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> My Work Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f9f9f9;
        }
        .container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
        }
        .header {
            background-color: #007bff;
            color: #fff;
            padding: 10px;
            text-align: center;
        }
        .content {
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }
        .footer {
            background-color: #007bff;
            color: #fff;
            padding: 10px;
            text-align: center;
        }
        .image-container {
            display: flex;
            justify-content: space-between;
            margin-top: 20px;
        }
        .image-container img {
            width: 30%;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }
        .image-info {
            flex-grow: 1;
            margin-left: 20px;
        }
        .ancient-description {
            font-family: "Times New Roman", Times, serif;
            font-style: italic;
        }
        .purchase-button {
            background-color: #007bff;
            color: #fff;
            padding: 5px 10px;
            border-radius: 5px;
            text-decoration: none;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>khumaloCraft</h1>
            </div>
            <div class="content">
                <!-- Your content goes here -->
                <div class="image-container">
                    <img src="https://i.pinimg.com/originals/74/08/b5/7408b5c6247847cb71bfb7c79823cdca.jpg" alt="Image 1">
                    <div class="image-info">
                        <p>This artifact is priced at R30000</p>
                        <a href="#" class="purchase-button">Purchase</a>
                    </div>
                </div>
                <div class="image-container">
                    <img src="https://maxwellpriceancientartifactscollection.com/wp-content/uploads/2021/06/VU_Brauer_2-18-20_0024-scaled.jpg" alt="Image 2">
                    <div class="image-info">
                        <p class="ancient-description">This artifact was crafted in the DRC by the local tribes and it symbolizes strength. They believed it provides them with protection too, discovered by Emmanual Tolu.</p>
                        <p>This artifact is priced at R150000</p>
                        <a href="#" class="purchase-button">Purchase</a>
                    </div>
                </div>
                <div class="image-container">
                    <img src="https://th.bing.com/th/id/OIP.8eyvXNygCEjcZJ5zLlLWywAAAA?rs=1&pid=ImgDetMain" alt="Image 4">
                    <div class="image-info">
                        <p class="ancient-description">This is an ancient artifact which was said to belong to a great emperor of Egypt and is almost 200 years old. It was discovered by the great Mark Johnson, who was a collector and sold the artifact at auction.</p>
                        <p>This artifact is priced at R100000</p>
                        <a href="#" class="purchase-button">Purchase</a>
                    </div>
                </div>
                <!-- New Image -->
                <div class="image-container">
                    <img src="https://th.bing.com/th/id/OIP.eFxRV4SGY-DoZRvdY0fhRgHaJu?rs=1&pid=ImgDetMain" alt="Image 5">
                    <div class="image-info">
                        <p class="ancient-description">This artifact was a symbol of the war that occurred in East Rome, symbolizing a warrior's strength. Discovered by Felix Roth.</p>
                        <p>This artifact is priced at R180000</p>
                        <a href="#" class="purchase-button">Purchase</a>
                    </div>
                </div>
            </div>
            <div class="footer">
                <p>&copy; 2024 KhumaloCraft. All rights reserved.</p>
            </div>
        </div>
    </form>
</body>
</html>
