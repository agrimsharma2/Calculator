#!/bin/bash
cd /var/www/
ASPNETCORE_ENVIRONMENT=Production ASPNETCORE_URLS=http://*:80 ./Calculator