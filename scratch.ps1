[System.Net.ServicePointManager]::ServerCertificateValidationCallback = { $true }

$body = @{message="This is a success message";testint=5;alertType="success";source="$($env:computername)"} | ConvertTo-Json
irm https://localhost:44300/Chat2 -Method Post -Body $body -ContentType 'application/json' 


#
#timeout 5
#$body = @{message="This is a Warning Message!";testint=5;alertType="warning";source="$($env:computername)"} | ConvertTo-Json
#irm https://localhost:44300/Chat2 -Method Post -Body $body -ContentType 'application/json' 
