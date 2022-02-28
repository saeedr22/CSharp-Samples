 
dotnet run saeed rezaei
if ( $LASTEXITCODE -eq 0) {
    Write-Host "This application has succeeded!"
}
else {
    Write-Host "This application has failed!"
}
Write-Host $LASTEXITCODE