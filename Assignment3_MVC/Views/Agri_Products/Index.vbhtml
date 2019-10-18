@ModelType IEnumerable(Of Assignment3_MVC.Assignment3_MVC.Agri_Products)
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
            @Html.DisplayNameFor(Function(model) model.Product_Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Product_Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Product_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Product_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Product_ID })
        </td>
    </tr>
Next

</table>
