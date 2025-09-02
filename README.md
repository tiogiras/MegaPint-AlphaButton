# MegaPint - Alpha Button

![Unity](https://img.shields.io/badge/Unity-2022%2B-blue.svg?logo=unity)
![Status](https://img.shields.io/badge/status-active-success.svg)
![License](https://img.shields.io/badge/license-Apache%202.0-green.svg)

This package is part of the **[MegaPint Collection](https://github.com/tiogiras/MegaPint)**.  
⚠️ **It cannot be used standalone** — it requires the **MegaPint Base Package** to function.

---

## About this Package?

Have you ever worked on a **UI or 2D game** where you had the perfect image for a button or interactive element,   
only to discover that Unity still treats the **entire rectangle** of the image as clickable?  

That’s where **Alpha Button** comes in.

## Features

✔️ A **custom button component** that behaves just like Unity’s standard button  
✔️ Adds an **alpha threshold slider** to control interactivity  
✔️ Use **1.0** → only fully opaque pixels register clicks  
✔️ Use **lower values** → allow semi-transparent pixels to count as interactive  

With this, you can finally create **buttons in any shape**   
and they will **only respond when the cursor is over visible pixels**.

<img width="768" height="431" alt="image" src="https://github.com/user-attachments/assets/983fec52-8461-43bb-8df6-48e35a79ff00" />

---

## ⚙️ Installation

1. Make sure the **[MegaPint Collection](https://github.com/tiogiras/MegaPint)** is installed in your Unity project.  
2. Install this package via MegaPints own internal Package Manager (`MegaPint > Package Manager`).  
3. After installation, refer to the added content in the Base Window for more information. 
