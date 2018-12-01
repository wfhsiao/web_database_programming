<pre>
use cmd (Admin) to run
appcmd list app > c:\users\wfhsiao\desktop\applist.bat
use vim to remove those apps you want to keep, as 
:g!:aspquiz1:d
(those lines do not contain aspquiz will be removed)
then add appcmd  delete to each line as
:%s:^:appcmd delete :
then you can run this applist.bat to delete those unwanted app.

appcmd to delete an application:
appcmd delete app "teaching/sources/ASP.NET/Programs/aspquiz1/aspnet/1049quiz1_a/1024060491/WebSite1"
</pre>
