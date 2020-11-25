<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserForm.aspx.cs" Inherits="SincoAF.Views.UserForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Users</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="../scripts/css/styles.css" />
    <link rel="stylesheet" type="text/css" href="../Content/DataTables/css/jquery.dataTables.min.css" />
</head>
<body>
    <header>
        <ul class="orange">
            <li><h2>SincoA&F</h2></li>
            <li><a class="btn" href="../Views/Users.html">Usuarios</a></li>
            <li><a class="btn" href="../Views/Products.html">Productos</a></li>
            <li><a class="btn" href="../Views/Orders.html">Órdenes</a></li>
        </ul>
    </header>

    <section>
        <article>
            <form id="UsersForm" action="/User/CreateUser">
                <div>
                    <label for="name">Nombre</label>
                    <input class="form-control" type="text" name="name" placeholder="Nombre" />
                </div>
                <div>
                    <label for="name">Email</label>
                    <input class="form-control" type="text" name="name" placeholder="Nombre" />
                </div>
                <div>
                    <label for="name">Rol</label>
                    <select class="form-control" name="roleid" id="UsersRole">
                        <option value="">Seleccione un Rol</option>
                    </select>
                </div>
            <div>
                <input class="btn orange block" id="SaveBtn" type="submit" value="Guardar" />
            </div>
            </form>
        </article>
        <article>
            <table id="UsersTable">
                <thead>
                    <tr>
                        <td>No</td>
                        <td>Name</td>
                        <td>Userame</td>
                        <td>Email</td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>No</td>
                        <td>Name</td>
                        <td>Userame</td>
                        <td>Email</td>
                    </tr>
                </tbody>
            </table>
        </article>
    </section>

    <script src="../scripts/jquery-3.5.1.min.js"></script>
    <script src="../scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="../scripts/js/Users.js"></script>
</body>
</html>
