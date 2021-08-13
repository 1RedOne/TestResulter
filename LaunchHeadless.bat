echo "publishing app as dll"
dotnet publish -c Release -o published
echo "launching headless"
dotnet C:\git\TestResulter\published\TestResultChat.dll