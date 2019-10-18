Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Assignment3_MVC.Assignment3_MVC

Namespace Controllers
    Public Class Agri_ProductsController
        Inherits System.Web.Mvc.Controller

        Private db As New Agriculture_DatabaseEntities

        ' GET: Agri_Products
        Function Index() As ActionResult
            Return View(db.Agri_Products.ToList())
        End Function

        ' GET: Agri_Products/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim agri_Products As Agri_Products = db.Agri_Products.Find(id)
            If IsNothing(agri_Products) Then
                Return HttpNotFound()
            End If
            Return View(agri_Products)
        End Function

        ' GET: Agri_Products/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Agri_Products/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Product_ID,Product_Name")> ByVal agri_Products As Agri_Products) As ActionResult
            If ModelState.IsValid Then
                db.Agri_Products.Add(agri_Products)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(agri_Products)
        End Function

        ' GET: Agri_Products/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim agri_Products As Agri_Products = db.Agri_Products.Find(id)
            If IsNothing(agri_Products) Then
                Return HttpNotFound()
            End If
            Return View(agri_Products)
        End Function

        ' POST: Agri_Products/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Product_ID,Product_Name")> ByVal agri_Products As Agri_Products) As ActionResult
            If ModelState.IsValid Then
                db.Entry(agri_Products).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(agri_Products)
        End Function

        ' GET: Agri_Products/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim agri_Products As Agri_Products = db.Agri_Products.Find(id)
            If IsNothing(agri_Products) Then
                Return HttpNotFound()
            End If
            Return View(agri_Products)
        End Function

        ' POST: Agri_Products/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim agri_Products As Agri_Products = db.Agri_Products.Find(id)
            db.Agri_Products.Remove(agri_Products)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
