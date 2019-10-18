@ModelType IEnumerable(Of Assignment3_MVC.Assignment3_MVC.Fruit)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Fruit_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Agri_Products.Product_Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Fruit_Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Agri_Products.Product_Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Fruit_ID}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Fruit_ID}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Fruit_ID})
        </td>
    </tr>
Next

</table>
