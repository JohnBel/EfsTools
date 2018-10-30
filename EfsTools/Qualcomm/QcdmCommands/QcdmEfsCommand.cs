namespace EfsTools.Qualcomm.QcdmCommands
{
    internal enum QcdmEfsCommand : byte
    {
        Hello = 0, // Parameter negotiation packet               
        Query = 1, // Send information about EFS2 params         
        Open = 2, // Open a file                                
        Close = 3, // Close a file                               
        Read = 4, // Read a file                                
        Write = 5, // Write a file                               
        Symlink = 6, // Create a symbolic link                     
        ReadLink = 7, // Read a symbolic link                       
        Unlink = 8, // Remove a symbolic link or file             
        Mkdir = 9, // Create a directory                         
        Rmdir = 10, // Remove a directory                         
        OpenDir = 11, // Open a directory for reading               
        ReadDir = 12, // Read a directory                           
        CloseDir = 13, // Close an open directory                    
        Rename = 14, // Rename a file or directory                 
        Stat = 15, // Obtain information about a named file      
        Lstat = 16, // Obtain information about a symbolic link   
        Fstat = 17, // Obtain information about a file descriptor 
        Chmod = 18, // Change file permissions                    
        StatFS = 19, // Obtain file system information             
        Access = 20, // Check a named file for accessibility       
        DevInfo = 21, // Get flash device info             
        FactoryImageStart = 22, // Start data output for Factory Image
        FactoryImageRead = 23, // Get data for Factory Image         
        FactoryImageEnd = 24, // End data output for Factory Image  
        PrepareFactoryImage = 25, // Prepare file system for image dump 
        EfsDepreciated = 26, // Write an EFS item file             
        GetDepreciated = 27, // Read an EFS item file              
        Error = 28, // Send an EFS Error Packet back through DIAG 
        ExtendedInfo = 29, // Get Extra information.                
        Chown = 30, // Change ownership                      
        BenchStartTest = 31, // Start Benchmark               
        BenchGetResults = 32, // Get Benchmark Report          
        BenchInit = 33, // Init/Reset Benchmark          
        SetReservation = 34, // Set group reservation         
        SetQuota = 35, // Set group quota               
        GetGroupInfo = 36, // Retrieve Q&R values           
        Deltree = 37, // Delete a Directory Tree       
        Put = 38, // Write a EFS item file in order
        Get = 39, // Read a EFS item file in order 
        Truncate = 40, // Truncate a file by the name   
        Ftruncate = 41, // Truncate a file by a descriptor 
        StatVFS_V2 = 42, // Obtains extensive file system info 
        Md5Sum = 43, // Calculate md5 hash of a file  
        HotplugFormat = 44, // Format a Connected device 
        Shred = 45, // Shred obsolete file content. 
        SetIdleDevEvntDur = 46, // Idle_dev_evt_dur value in mins 
        HotplugDeviceInfo = 47, // get the hotplug device info.  
        SyncNoWait = 48, // non-blocking sync of remotefs device 
        SyncGetStatus = 49, // query previously issued sync status 
        Truncate64 = 50, // Truncate a file by the name.        
        Ftruncate64 = 51, // Truncate a file by a descriptor.    
        Lseek64 = 52, // Seek to requested file offset.      
        MakeGoldenCopy = 53, // Make golden copy for Remote Storage
        FsImageOpen = 54, //Open FileSystem Image extraction
        FsImageRead = 55, // Read File System Image.        
        FsImageClose = 56 // Close File System Image.      
    }
}