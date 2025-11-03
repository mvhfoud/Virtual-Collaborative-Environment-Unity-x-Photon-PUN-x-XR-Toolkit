# 🕶️ Virtual Collaborative Environment – Unity x Photon PUN x XR Toolkit

## 🌍 Overview
This project is about creating a **shared virtual world** where several users can connect, see each other, and interact in real time.  
It was made with **Unity**, **Photon PUN**, and the **XR Interaction Toolkit**.  

The main goal was to make users feel like they are together in the same 3D space — moving, grabbing objects, and creating things that everyone can see instantly.

---

## What It Can Do
- Connects **multiple users** online through **Photon PUN**, which uses a **UDP-based network** for fast and smooth communication.  
- Lets users **grab, move, and drop** 3D objects using physics (`Rigidbody`, `Collider`).  
- Keeps all players **perfectly in sync** using `PhotonView` and `PhotonTransformView`.  
- Allows **live object creation** — press `Space` and a cube appears for everyone.  
- Handles **ownership transfer**, so only one player controls an object at a time.  
- Shows a **3D cursor** for each player that everyone can see.  
- (Work in progress) Adds **chat bubbles** above avatars to improve collaboration.

---

## Scenes and Structure
- **Launcher Scene** – connects players to the Photon network and joins/creates rooms.  
- **Arena Scene** – the shared 3D space where players interact together.  
- **Prefabs** – contains all networked objects and avatars configured with Photon.

---

## How Networking Works
Photon PUN is built on top of a **custom UDP protocol** made for real-time games.  
UDP is faster than TCP because it sends data continuously without waiting for confirmation.  
Photon adds its own **reliability and order system**, so even if a packet is lost, it resends it quickly.  
If UDP isn’t available (for example, in WebGL or some networks), it automatically switches to **WebSockets**.

