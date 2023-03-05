# Furn-X-Ar

<img src="https://live.staticflickr.com/65535/52725281108_725384dcac_b.jpg"
    alt="Furn-X-Ar Logo"
    style="display: block;
    margin-left: auto;
    margin-right: auto;
    width: 50%;
    border-radius : 4%; "
/>

## Introduction

Introducing our augmented reality application that allows you to visualize furniture in real time, bringing your interior design visions to life. With our app, you can easily preview furniture in your own space, adjust size and placement, and get a realistic feel for how it will look before making any changes. Whether you're an interior designer, architect, or simply someone who enjoys experimenting with different design ideas, our app offers a seamless and immersive experience that allows you to unleash your creativity and explore endless possibilities. 

## The Problem

Despite advancements in online furniture shopping, customers still face challenges in visualizing how a piece of furniture will look and fit in their home. Traditional 2D images or videos can be inadequate in providing an accurate representation of the size, scale, and style of the furniture. This can result in a lack of confidence in purchasing decisions, high rates of return, and ultimately, dissatisfaction with the shopping experience. Therefore, there is a need for an AR furniture application that can provide customers with an immersive and interactive experience, allowing them to virtually place furniture in their home environment and visualize how it will look and fit before making a purchase.

## Our Solution

To tackle the same, we have designed the AR based application which helps the user to view the particular selected furniture to be viewd in real time in actual space, giving the user a virtual experience of the actual exixtance of the funiture in the area, allowing the user to have an almost accurate idea about the existance of the furniture in the plane.



## Functionality

The AR Furniture Application offers users the ability to view furniture in real-time, allowing them to visualize how the furniture would look in their space without actually owning the furniture physically. This feature offers users an opportunity to experiment with furniture placement and space allocation, which is especially useful for those who are in the process of moving or redecorating.

The application utilizes planar detection using the Vuforia Engine. It uses marker-less panal detection, (i.e.) the 3d models can be projected on ant kind of planar surface.

The 3D models are being rendered in real time uisng C# scripting.


Overall, the AR Furniture Application offers an engaging and efficient shopping experience for users, with the added benefit of visualization through AR technology. The purchasing and cart features provide a seamless experience for customers, further enhancing the app's appeal and value.


## Tech Stack

The application is based on Unity and is native to Android Operating System. It makes use of the Vuforia engine for ground plane detection, marker-less and marker-based. The overall application is scripted in C# language in unity.

We have used Ground Plane Detection which allows the application to detect the plane and simultaneously project the AR models in real-time via the app

## Time-Line

### 1. Initial Stage

The project was initiated from the ground up, with 3D models created using Blender and implemented in Unity 3D Engine. Initially, the application was capable of displaying only models on the plane, with measurements that were not accurate according to the environment. Additionally, 3D models were restricted to a single viewpoint, with no option for rotation, scaling or movement.

Furthermore, the application lacked a proper User Interface and functional capabilities, making it less user-friendly and less efficient.


### 2. The Next Stage

At this stage, the application incorporated more 3D models and functionalities, including the product description page that allows users to view details of their selected product, along with the option to purchase the furniture (Non-functional) and its corresponding price tag. The product description page also included a 70-word short description about the product.

Furthermore, the application had many functional components, making it more efficient and user-friendly. The User Interface (UI) also began taking its final form, indicating significant progress in the development of the application.


### 3. Adding Model Controls

At this point the application lacked the feature of moving, resizing or rotaing the 3D models. Along with that the scaling issue persisted where the model was not shown in full scale accoring to the actual environment in which the model was being rendered.

These issues were fixed in this stage allowing the user to freely move the 3D model along the plane, and rotate it according to the requirement and resize. The scalablity issue was almost fixed at this stage and required more work.

### 4. Fixing The UI

At this point, the application lacked critical features, such as the ability to move, resize or rotate 3D models. Additionally, the scaling issue persisted, with the model not displayed to scale according to the actual environment in which it was being rendered.

In this stage, these issues were successfully addressed, enabling users to freely move the 3D model, rotate it to their liking, and resize it as per their requirements. Although the scalability issue was mostly resolved at this stage, some additional work was required to ensure it was fully resolved.

Overall, these enhancements significantly improved the application's usability and user experience, further advancing its development

### 5. Finalizing

The application's User Interface (UI) required further refinement to enhance its efficiency. To achieve this, new modern designs were incorporated, and the overall navigation within the application was improved. These changes were implemented to make the UI more intuitive and user-friendly, providing an overall smoother user experience.

By refining the UI, users were able to more easily navigate through the application, find the products they were interested in, and make purchases. These improvements further advanced the development of the application, making it a more competitive player in the AR furniture application market.


## Overall Summary

Up until now the basic UI and the AR model views are working properly. 

Only thing which isnt functional is the "BUY NOW" option, as we havent implementd the same, and we are planning to do implement the same same real soon.
