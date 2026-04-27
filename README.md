# SmartHome

SmartHome is a unified ecosystem for local smart home control. It integrates devices from various brands (Tapo, Emos) and custom ESP32 sensors via MQTT. Features a .NET backend, a cross-platform web dashboard, and a mobile app for convenient monitoring and automation.

## Project Structure

This repository is divided into several main modules:

* `Backend/` — Server-side logic and API (recommended stack: .NET Core Web API). Responsible for communicating with devices, the MQTT broker, and executing automation logic.
* `Frontend/` — Client web dashboard for browser-based control (recommended stack: Blazor WebAssembly or React).
* `Mobile/` — Mobile application for Android/iOS (recommended stack: .NET MAUI or PWA based on the web version).
* `Docs/` — Project documentation, architectural diagrams, and skill files (such as `AGENTS.md` or `RULES.md`).
