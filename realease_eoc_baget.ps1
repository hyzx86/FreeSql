$Version="3.2.802-jzbeta-230927"
dotnet pack FreeSql/FreeSql.csproj --output artifacts --configuration Release -p:Version=$Version
dotnet nuget push "artifacts/FreeSql.${Version}.nupkg" --api-key 123123/e --source https://nuget.jizhousoft.com/v3/index.json