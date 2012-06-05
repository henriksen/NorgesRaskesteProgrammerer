param(
  [string]$email = $(Read-Host -prompt "E-mail address")
 );

 git branch $email
 git checkout $email
 echo $email > contestant.txt
 git add .
 git commit -a -m "Start!"