using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.RegularExpressions;

public class DatabaseAccess : MonoBehaviour
{
    MongoClient client = new MongoClient("mongodb+srv://mernproject:mernproject@cluster0.suazl.mongodb.net/?retryWrites=true&w=majority");
    IMongoDatabase database;
    IMongoCollection<BsonDocument> collection;

    private static controlarPuntos felicidad;
    private static controlarPuntos energia;
    private static controlarPuntos irritabilidad;
    private static controlarPuntos estres;
    private static controlarPuntos ansiedad;
    private static controlarPuntos obesidad;
    private static controlarPuntos salud;
    private static controlarPuntos depresion;


    private static userId id;

    void Start()
    {
        database = client.GetDatabase("Cluster0");
        collection = database.GetCollection<BsonDocument>("tasks");

        id = FindObjectOfType<userId>();

        felicidad = FindObjectOfType<controlarPuntos>();
        energia = FindObjectOfType<controlarPuntos>();
        irritabilidad = FindObjectOfType<controlarPuntos>();
        estres = FindObjectOfType<controlarPuntos>();
        ansiedad = FindObjectOfType<controlarPuntos>();
        obesidad = FindObjectOfType<controlarPuntos>();
        salud = FindObjectOfType<controlarPuntos>();
        depresion = FindObjectOfType<controlarPuntos>();

    }

    public void enviarDatos(string MJ)
    {
        Debug.Log(id.id);

        var datos = new BsonDocument { { "ID", id.id },{"minijuego",MJ },{ "felicidad", felicidad.cantidadPuntosFelicidad.ToString() },{ "energia", energia.cantidadPuntosEnergia }, { "irritabilidad", irritabilidad.cantidadPuntosIrritabilidad }, { "estres", estres.cantidadPuntosEstres }, { "ansiedad", ansiedad.cantidadPuntosAnsiedad }, { "obesidad", obesidad.cantidadPuntosObesidad }, { "salud", salud.cantidadPuntosSalud }, { "depresion", depresion.cantidadPuntosDepresion }};
        

        collection.InsertOne(datos);
    }
}