# Movie Poster Slideshow

## 📘 Overview

A simple **C# photo slideshow** that displays posters of favorite movies.
The program dynamically loads images from a text file (`photos.txt`), allowing the user to easily add, remove, or change posters without modifying the source code.

## 🏗️ Tech Stack

* **Language:** C#
* **Framework:** .NET (Windows Forms)

## ⚙️ How It Works

1. The program reads image file paths from `photos.txt`.
2. It loads the images in sequence and displays them as a slideshow.
3. Users can update the slideshow by editing `photos.txt` (e.g., adding/removing paths to new movie posters).

## 📊 Features

* Dynamic loading of movie posters.
* Easy customization via plain text file.
* Slideshow navigation (automatic).

## ▶️ Usage

1. Place your poster image files in the project folder.
2. Edit `photos.txt` and list each image file path on a new line, for example:

   ```
   poster1.jpg
   poster2.png
   poster3.jpg
   ```
3. Run the program.
4. The slideshow will update automatically based on the contents of `photos.txt`.

---
