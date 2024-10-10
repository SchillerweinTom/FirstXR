# FirstXR - Unity Project

## Project Overview

This Unity project is designed for a school assignment and implements a basic interactive room with various mechanics. The player can interact with drawers, doors, and objects while using a variety of tools like magnetic keys, a brush, and a radio. The project also includes a simple saving system and a UI that appears based on interactions. Below is a detailed breakdown of the game's mechanics, UI, and saving system.

## Mechanics

### 1. Interactive Drawers with Objects
- Several drawers are created, each containing different items like **magnetic keys** and **regular keys**.
- The player can **pick up and move** these objects.

### 2. Magnetic Key System
- A door can only be opened by activating a **magnetic key card**.
- When the key card is placed over the reader, the reader lights up **green**, indicating activation.

### 3. UI Interaction System
- A **UI** will appear when an interactable scene object (e.g., a PC) is clicked.
- The UI includes:
  - **Buttons** to lock and unlock a chest.
  - An **Slider** to select the color of the brush.

### 4. Radio
- A radio is included in the scene, and pressing the On button will start playing **background music**.

### 5. Color Changing Brush
- A brush can change the color of objects in the scene.
- The color of the brush can be selected through a **UI color picker**.
- INFO: This Feature is currently not working, but partially implemented if looked in the code!
