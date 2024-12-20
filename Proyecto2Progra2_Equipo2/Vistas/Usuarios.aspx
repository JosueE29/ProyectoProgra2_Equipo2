<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PlantillaMenu.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Proyecto2Progra2_Equipo2.Vistas.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style>
     /*user: admin*/
   /*contra: admin123*/
        body {
            font-family: Arial, sans-serif;
            background-color: #b3e5fc;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
        }

        .main-container {
            width: 100%;
            display: flex;
            flex-direction: column;
            align-items: center;
            gap: 20px;
        }

        .container {
            background-color: white;
            padding: 30px;
            border-radius: 15px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
            margin: 15px auto;
            width: 90%;
            max-width: 1200px;
            text-align: center;
        }

        h2 {
            text-align: center;
            margin-bottom: 20px;
        }

        label {
            display: block;
            margin-top: 10px;
        }

        .input-field {
            width: 100%;
            padding: 5px;
            margin-top: 5px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .btn {
            width: 100%;
            padding: 10px;
            margin-top: 10px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        .btn:hover {
            background-color: #0056b3;
        }

        .grid-view {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
            text-align: left;
        }

        .grid-view th, .grid-view td {
            border: 1px solid #ddd;
            padding: 8px;
        }
    </style>
            <div class="container">
            <h2>Lista de Usuarios</h2>

            <asp:GridView ID="GridViewUsers" CssClass="grid-view" runat="server"></asp:GridView>


            <label for="UserIDTextBox">ID de Usuario:</label>
            <asp:TextBox ID="UserIDTextBox" type="number" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="NombreTextBox">Nombre del Usuario:</label>
            <asp:TextBox ID="NombreTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="EmailUserTextBox">Correo Electrónico:</label>
            <asp:TextBox ID="EmailUserTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="TelefonoUserTextBox">Teléfono:</label>
            <asp:TextBox ID="TelefonoUserTextBox" type="number" CssClass="input-field" runat="server"></asp:TextBox>

            <asp:Button ID="AgregarUser" runat="server" CssClass="btn" Text="Agregar" OnClick="AgregarUser_Click" />
            <asp:Button ID="BorrarUser" runat="server" CssClass="btn" Text="Borrar" OnClick="BorrarUser_Click" />
            <asp:Button ID="ModificarUser" runat="server" CssClass="btn" Text="Modificar" OnClick="ModificarUser_Click" />
        </div>
</asp:Content>
