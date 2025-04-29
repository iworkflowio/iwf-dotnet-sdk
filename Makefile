idl-code-gen: #generate/refresh csharp code for idl (API schema), do this after updating the idl file
	rm -Rf ./src/IwfDotnetSdk.ApiClients ; true
	java -jar openapi-generator-cli-7.9.0.jar generate -i iwf-idl/iwf-sdk.yaml -g csharp -o src/IwfDotnetSdk/ApiClients -p packageName=IwfDotnetSdk.ApiClients -p generateInterfaces=true --git-user-id indeedeng --git-repo-id iwf-idl
	mv ./src/IwfDotnetSdk/ApiClients/src/IwfDotnetSdk.ApiClients ./src
	rm -Rf ./src/IwfDotnetSdk/ApiClients; true

