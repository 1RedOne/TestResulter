[System.Net.ServicePointManager]::ServerCertificateValidationCallback = { $true }

$body = @{msg="This is a success message";testint=5;alertType="success"} | ConvertTo-Json
irm https://localhost:44300/Chat2 -Method Post -Body $body -ContentType 'application/json' 

timeout 5
$body = @{msg="This is a Warning Message!";testint=5;alertType="warning"} | ConvertTo-Json
irm https://localhost:44300/Chat2 -Method Post -Body $body -ContentType 'application/json' 