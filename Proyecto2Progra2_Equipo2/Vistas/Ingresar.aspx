<%@ Page Title="Inicio de Sesión" Language="C#" MasterPageFile="~/Vistas/PlantillaMenu.Master" AutoEventWireup="true" CodeBehind="Ingresar.aspx.cs" Inherits="Proyecto2Progra2_Equipo2.Vistas.Ingresar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
/*PROYECTO 2 PROGRAMACION 2*/
/*EQUIPO 2*/
/*LEZCANO LUNA KEVIN ANDREI*/
/*MALESPIN PALACIOS IAN GENARO*/
/*JUAREZ NARANJO ZULLIANY MARIA*/
/*ESPINOZA CASTILLO JOSUE DAVID*/
/*Curso INFO-104*/
/*Prof.Benjamin Curling*/
/*PROYECTO 2 PROGRAMACION 2*/


       /*USER: admin*/
       /*contra: admin123*/
        .login-container {
            margin: 50px auto;
            width: 300px;
            padding: 20px;
            background-color: #ffffff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
            font-family: Arial, sans-serif;
        }
        .login-container h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .login-container label {
            display: block;
            margin-bottom: 8px;
            font-weight: bold;
        }
        .login-container input[type="text"],
        .login-container input[type="password"] {
            width: 100%;
            padding: 8px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .login-container button {
            width: 100%;
            padding: 10px;
            background-color: #4CAF50;
            color: #fff;
            border: none;
            border-radius: 4px;
            font-size: 16px;
            cursor: pointer;
        }
        .login-container button:hover {
            background-color: #45a049;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-container">
        <h2>Iniciar Sesión</h2>
        <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
        <asp:TextBox ID="UsernameTextBox" runat="server" placeholder="Nombre de Usuario"></asp:TextBox>
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
        <asp:Button ID="LoginButton" runat="server" Text="Iniciar Sesión" OnClick="LoginButton_Click" />
    </div>
</asp:Content>
