$body = @{msg="Test1";testint=5} | ConvertTo-Json
irm https://localhost:44300/Chat2 -Method Post -Body $body -ContentType 'application/json'