# SmartHome Backend

This directory contains the server-side logic and API for the SmartHome ecosystem. 

## Overview
The backend acts as the central hub, responsible for:
- Connecting to the MQTT broker to receive data from ESP32 nodes.
- Interfacing with third-party devices (Tapo, Emos).
- Executing automation rules and logic.
- Providing a REST API and SignalR endpoints for the Frontend and Mobile applications.
- Interacting with the database (e.g., PostgreSQL or SQLite) to store sensor history and states.

## Recommended Stack
* **Framework:** .NET 8 / .NET Core Web API
* **IoT Protocol:** MQTT (via MQTTnet)
* **Database ORM:** Entity Framework Core
