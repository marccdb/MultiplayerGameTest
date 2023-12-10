using UnityEngine;
using Mirror;


public class NetworkManagerScript : NetworkManager
{


    public override void OnStartServer()
    {
        Debug.Log("Server has started");
    }

    public override void OnStopServer()
    {
        Debug.Log("Server has been stopped");
    }

    public override void OnClientConnect()
    {
        Debug.Log("Client has connected");
    }

    public override void OnClientDisconnect()
    {
        Debug.Log("Client has disconnected");
    }

}
