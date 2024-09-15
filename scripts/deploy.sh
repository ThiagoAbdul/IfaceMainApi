aws ecr get-login-password --region us-east-2 | docker login --username AWS --password-stdin 571600842636.dkr.ecr.us-east-2.amazonaws.com

docker build -t iface/iface-main-api .

docker tag iface/iface-main-api:latest 571600842636.dkr.ecr.us-east-2.amazonaws.com/iface/iface-main-api:latest

docker push 571600842636.dkr.ecr.us-east-2.amazonaws.com/iface/iface-main-api:latest