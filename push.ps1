Write-Host "=-=-=-=-=-= GITHUB & BITBUCKET PUSH SCRIPT =-=-=-=-=-=" -ForegroundColor White
Write-Host "Pushing to remote Bitbucket, please wait (1/2)" -ForegroundColor DarkGreen
git push
Write-Host "Pushing to remote GitHub, please wait (2/2)" -ForegroundColor DarkGreen
git push mirror
Write-Host "PUSH SUCCESSFUL (2/2)" -ForegroundColor Green