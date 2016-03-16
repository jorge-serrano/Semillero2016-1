/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.edu.yuxi.beans;

/**
 *
 * @author jheison.cardona
 */
public abstract class  Animal {
    
    private int id;
    private String animalType;
    private int foodType;
    private String patas;
    private String color;
    
    public Animal(){}
    
    public Animal(int id, String animalType, int foodType, String patas, String color) {
        this.id = id;
        this.animalType = animalType;
        this.foodType = foodType;
        this.patas = patas;
        this.color = color;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getAnimalType() {
        return animalType;
    }

    public void setAnimalType(String animalType) {
        this.animalType = animalType;
    }

    public int getFoodType() {
        return foodType;
    }

    public void setFoodType(int foodType) {
        this.foodType = foodType;
    }

    public String getPatas() {
        return patas;
    }

    public void setPatas(String patas) {
        this.patas = patas;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }
     
    public  abstract void eat();
    public  abstract void seleep();
    public  abstract void defecate();
    public  abstract void breed();
    public  abstract void die();
            
    
    public void ReduceEnergy(){
        int Energy=0;
    
     Energy--;
    }
}
