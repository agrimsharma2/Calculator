#!/bin/bash
cd /var/www/
ASPNETCORE_ENVIRONMENT=Production ASPNETCORE_URLS=http://*:80 nohup ./Calculator > /dev/null 2>&1 &