namespace EfsTools.Qualcomm.QcdmCommands
{
    internal enum QcdmEfsCommand : byte
    {
        EfsHello = 0, // Parameter negotiation packet               
        EfsQuery = 1, // Send information about EFS2 params         
        EfsOpen = 2, // Open a file                                
        EfsClose = 3, // Close a file                               
        EfsRead = 4, // Read a file                                
        EfsWrite = 5, // Write a file                               
        EfsSymlink = 6, // Create a symbolic link                     
        EfsReadLink = 7, // Read a symbolic link                       
        EfsUnlink = 8, // Remove a symbolic link or file             
        EfsMkdir = 9, // Create a directory                         
        EfsRmdir = 10, // Remove a directory                         
        EfsOpenDir = 11, // Open a directory for reading               
        EfsReadDir = 12, // Read a directory                           
        EfsCloseDir = 13, // Close an open directory                    
        EfsRename = 14, // Rename a file or directory                 
        EfsStat = 15, // Obtain information about a named file      
        EfsLstat = 16, // Obtain information about a symbolic link   
        EfsFstat = 17, // Obtain information about a file descriptor 
        EfsChmod = 18, // Change file permissions                    
        EfsStatFS = 19, // Obtain file system information             
        EfsAccess = 20, // Check a named file for accessibility       
        EfsDevInfo = 21, // Get flash device info             
        EfsFactoryImageStart = 22, // Start data output for Factory Image
        EfsFactoryImageRead = 23, // Get data for Factory Image         
        EfsFactoryImageEnd = 24, // End data output for Factory Image  
        EfsPrepareFactoryImage = 25, // Prepare file system for image dump 
        EfsEfsDepreciated = 26, // Write an EFS item file             
        EfsGetDepreciated = 27, // Read an EFS item file              
        EfsError = 28, // Send an EFS Error Packet back through DIAG 
        EfsExtendedInfo = 29, // Get Extra information.                
        EfsChown = 30, // Change ownership                      
        EfsBenchStartTest = 31, // Start Benchmark               
        EfsBenchGetResults = 32, // Get Benchmark Report          
        EfsBenchInit = 33, // Init/Reset Benchmark          
        EfsSetReservation = 34, // Set group reservation         
        EfsSetQuota = 35, // Set group quota               
        EfsGetGroupInfo = 36, // Retrieve Q&R values           
        EfsDeltree = 37, // Delete a Directory Tree       
        EfsPut = 38, // Write a EFS item file in order
        EfsGet = 39, // Read a EFS item file in order 
        EfsTruncate = 40, // Truncate a file by the name   
        EfsFtruncate = 41, // Truncate a file by a descriptor 
        EfsStatVFS_V2 = 42, // Obtains extensive file system info 
        EfsMd5Sum = 43, // Calculate md5 hash of a file  
        EfsHotplugFormat = 44, // Format a Connected device 
        EfsShred = 45, // Shred obsolete file content. 
        EfsSetIdleDevEvntDur = 46, // Idle_dev_evt_dur value in mins 
        EfsHotplugDeviceInfo = 47, // get the hotplug device info.  
        EfsSyncNoWait = 48, // non-blocking sync of remotefs device 
        EfsSyncGetStatus = 49, // query previously issued sync status 
        EfsTruncate64 = 50, // Truncate a file by the name.        
        EfsFtruncate64 = 51, // Truncate a file by a descriptor.    
        EfsLseek64 = 52, // Seek to requested file offset.      
        EfsMakeGoldenCopy = 53, // Make golden copy for Remote Storage
        EfsFsImageOpen = 54, //Open FileSystem Image extraction
        EfsFsImageRead = 55, // Read File System Image.        
        EfsFsImageClose = 56 // Close File System Image.    
    }
}