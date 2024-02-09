# Use an official Golang runtime as a base image
FROM golang:alpine

# Set the working directory inside the container
WORKDIR /app

# Copy the local package files to the container's workspace
COPY . .

# Download and install any dependencies your app needs
RUN go mod download


RUN go build -o main .


ENV API_MODE="production"
CMD sleep 20 && ["./main"]