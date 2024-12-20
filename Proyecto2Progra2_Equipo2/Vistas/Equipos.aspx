<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/PlantillaMenu.Master" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="Proyecto2Progra2_Equipo2.Vistas.Equipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
            <style>
                /*USER: admin*/
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
            <h2>Lista de Equipos</h2>

            <asp:GridView ID="GridViewEquipos" CssClass="grid-view" runat="server"></asp:GridView>


            <label for="EquiposIDTextBox">ID del Equipo:</label>
            <asp:TextBox ID="EquiposIDTextBox" type="number" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="TipoEquipoTextBox">Tipo De Equipo:</label>
            <asp:TextBox ID="TipoEquipoTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="ModeloTextBox">Modelo:</label>
            <asp:TextBox ID="ModeloTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            <label for="UserIDTextBox">User ID:</label>
            <asp:TextBox ID="UserIDTextBox" CssClass="input-field" runat="server"></asp:TextBox>

            

            <asp:Button ID="AgregarEquipo" runat="server" CssClass="btn" Text="Agregar" OnClick="AgregarEquipo_Click" />
            <asp:Button ID="BorrarEquipo" runat="server" CssClass="btn" Text="Borrar" OnClick="BorrarEquipo_Click" />
            <asp:Button ID="ModificarEquipo" runat="server" CssClass="btn" Text="Modificar" OnClick="ModificarEquipo_Click" />
        </div>
</asp:Content>
