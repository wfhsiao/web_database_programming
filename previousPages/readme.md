Three methods to transfer data between pages:
(1) button's postbackurl
(2) button_click use server.transfer method
(3) Session

The first two methods can use PreviousPage Object to access like:
PreviousPage.FindControl("Button1")
