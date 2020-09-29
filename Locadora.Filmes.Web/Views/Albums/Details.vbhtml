@ModelType Locadora.Filmes.Dominio.Album

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <div>
        <h4>Album</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.Nome)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Nome)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Ano)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Ano)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.Descricao)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.Descricao)
            </dd>
    
        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>
