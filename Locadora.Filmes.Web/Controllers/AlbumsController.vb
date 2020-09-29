Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Locadora.Filmes.Dados.Entity.Context
Imports Locadora.Filmes.Dominio

Namespace Controllers
    Public Class AlbumsController
        Inherits System.Web.Mvc.Controller

        Private db As New FilmeDbContext

        ' GET: Albums
        Function Index() As ActionResult
            Return View(db.albuns.ToList())
        End Function

        ' GET: Albums/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim album As Album = db.albuns.Find(id)
            If IsNothing(album) Then
                Return HttpNotFound()
            End If
            Return View(album)
        End Function

        ' GET: Albums/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Albums/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Nome,Ano,Descricao")> ByVal album As Album) As ActionResult
            If ModelState.IsValid Then
                db.albuns.Add(album)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(album)
        End Function

        ' GET: Albums/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim album As Album = db.albuns.Find(id)
            If IsNothing(album) Then
                Return HttpNotFound()
            End If
            Return View(album)
        End Function

        ' POST: Albums/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Nome,Ano,Descricao")> ByVal album As Album) As ActionResult
            If ModelState.IsValid Then
                db.Entry(album).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(album)
        End Function

        ' GET: Albums/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim album As Album = db.albuns.Find(id)
            If IsNothing(album) Then
                Return HttpNotFound()
            End If
            Return View(album)
        End Function

        ' POST: Albums/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim album As Album = db.albuns.Find(id)
            db.albuns.Remove(album)
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
