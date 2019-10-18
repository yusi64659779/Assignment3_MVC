@ModelType IEnumerable(Of Assignment3_MVC.Assignment3_MVC.Vegetable)
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
            @Html.DisplayNameFor(Function(model) model.Veg_Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Agri_Products.Product_Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Veg_Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Agri_Products.Product_Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Veg_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Veg_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Veg_ID })
        </td>
    </tr>
Next

</table>
