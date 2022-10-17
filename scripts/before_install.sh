#!/bin/bash
deploymentGroupId=$(aws deploy get-deployment-group --application-name calculator_app --deployment-group-name dev_group --query "deploymentGroupInfo.deploymentGroupId" --region ap-southeast-2)
deploymentId=$(aws deploy get-deployment-group --application-name calculator_app --deployment-group-name dev_group --query "deploymentGroupInfo.lastAttemptedDeployment.deploymentId" --region ap-southeast-2)
deploymentGroupId=("${deploymentGroupId: 1:-1}")
deploymentId=("${deploymentId: 1:-1}")
cd deployment-root/$deploymentGroupId/$deploymentId/deployment-archive/CalculatorApp
dotnet publish -o ../build