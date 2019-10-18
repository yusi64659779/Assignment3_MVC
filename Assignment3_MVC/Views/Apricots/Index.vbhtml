@ModelType IEnumerable(Of Assignment3_MVC.Assignment3_MVC.Apricot)
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
            @Html.DisplayNameFor(Function(model) model.Form)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Average_Retail_Price_Dollars)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Price_Unit)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Preparation_yield_Factor)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Size_Cup_Equivalent)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Size_Unit)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Average_Price_Per_Cup_Dollars)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Fruit.Fruit_Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Form)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Average_Retail_Price_Dollars)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Price_Unit)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Preparation_yield_Factor)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Size_Cup_Equivalent)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Size_Unit)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Average_Price_Per_Cup_Dollars)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Fruit.Fruit_Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Form_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Form_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Form_ID })
        </td>
    </tr>
Next

</table>
