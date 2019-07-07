//Maya ASCII 2014 scene
//Name: crystalCollectible.ma
//Last modified: Sun, Mar 01, 2015 12:52:16 PM
//Codeset: UTF-8
requires maya "2014";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2014";
fileInfo "version" "2014 x64";
fileInfo "cutIdentifier" "201303010035-864206";
fileInfo "osv" "Mac OS X 10.8.5";
fileInfo "license" "student";
createNode transform -n "crystalCollectible";
	setAttr ".rp" -type "double3" 1.4310953097380263 30.07801888977373 2.5074983541861116 ;
	setAttr ".sp" -type "double3" 1.4310953097380263 30.07801888977373 2.5074983541861116 ;
createNode mesh -n "crystalCollectibleShape" -p "crystalCollectible";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 42 ".uvst[0].uvsp[0:41]" -type "float2" 0 0 0.34765622 6.7848007e-17
		 0.78776038 0.13020827 1 0.39322913 0.97786456 0.79947913 0.51432294 0.91536456 0.092447869
		 0.47786462 0 0 0.34765622 6.7848007e-17 0.78776038 0.13020827 1 0.39322913 0.97786456
		 0.79947913 0.51432294 0.91536456 0.092447869 0.47786462 0 0 0.34765622 6.7848007e-17
		 0.78776038 0.13020827 1 0.39322913 0.97786456 0.79947913 0.51432294 0.91536456 0.092447869
		 0.47786462 0 0 0.092447869 0.47786462 0.51432294 0.91536456 0.97786456 0.79947913
		 1 0.39322913 0.78776038 0.13020827 0.34765622 6.7848007e-17 0 0 0.34765622 6.7848007e-17
		 0.34765622 6.7848007e-17 0 0 0.78776038 0.13020827 0.78776038 0.13020827 1 0.39322913
		 1 0.39322913 0.97786456 0.79947913 0.97786456 0.79947913 0.51432294 0.91536456 0.51432294
		 0.91536456 0.092447869 0.47786462 0.092447869 0.47786462;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 28 ".pt[0:27]" -type "float3"  2.0504847 36.36594 -2.30336 
		7.221355 31.996305 -3.3032513 9.6836662 24.799528 -4.3300743 7.4675841 19.601852 
		-4.6626377 0.32687092 16.403288 -4.2757111 -6.5676126 21.800873 -2.9886494 -3.612834 
		31.396578 -2.2583256 2.8204556 45.661453 4.6005402 12.802937 36.552155 3.602293 16.395475 
		24.912331 3.2430382 12.771627 15.490326 3.605423 0.098554611 9.1974945 4.8727131 
		-12.133281 19.812973 6.0959148 -7.7267437 35.67651 5.6552429 3.4209871 35.652649 
		11.089986 8.2819614 31.595268 11.179744 10.596701 24.912798 11.947526 8.5134373 20.086567 
		12.911063 1.8006563 17.116589 14.095605 -4.6806479 22.128441 14.036708 -1.9029474 
		31.038399 12.374206 2.8204556 45.661453 4.6005402 12.802937 36.552155 3.602293 16.395475 
		24.912331 3.2430382 12.771627 15.490326 3.605423 0.098554611 9.1974945 4.8727131 
		-12.133281 19.812973 6.0959148 -7.7267437 35.67651 5.6552429;
	setAttr -s 28 ".vt[0:27]"  0 3.79141879 -2.22595143 0 3.24026442 -1.69643176
		 0 2.33251643 -1.44427931 0 1.67692053 -1.67121649 0 1.27347708 -2.40245795 0 1.95428813 -3.10848427
		 0 3.16461897 -2.80590153 -0.69999993 4.67431927 -2.22013903 -0.69999993 3.66217518 -1.22189105
		 -0.69999993 2.3688612 -0.8626371 -0.69999993 1.32197177 -1.22502184 -0.69999993 0.62276775 -2.4923296
		 -0.69999993 1.802266 -3.71551299 -0.69999993 3.56488037 -3.27485943 -1.39999986 3.79141879 -2.22595143
		 -1.39999986 3.24026442 -1.69643176 -1.39999986 2.33251643 -1.44427931 -1.39999986 1.67692053 -1.67121649
		 -1.39999986 1.27347708 -2.40245795 -1.39999986 1.95428813 -3.10848427 -1.39999986 3.16461897 -2.80590153
		 -0.69999993 4.67431927 -2.22013903 -0.69999993 3.66217518 -1.22189105 -0.69999993 2.3688612 -0.8626371
		 -0.69999993 1.32197177 -1.22502184 -0.69999993 0.62276775 -2.4923296 -0.69999993 1.802266 -3.71551299
		 -0.69999993 3.56488037 -3.27485943;
	setAttr -s 42 ".ed[0:41]"  0 1 0 1 2 0 2 3 0 3 4 0 4 5 0 5 6 0 6 0 0
		 0 7 0 1 8 0 7 8 0 2 9 0 8 9 0 3 10 0 9 10 0 4 11 0 10 11 0 5 12 0 11 12 0 6 13 0
		 12 13 0 13 7 0 14 15 0 15 16 0 16 17 0 17 18 0 18 19 0 19 20 0 20 14 0 14 21 0 15 22 0
		 21 22 0 16 23 0 22 23 0 17 24 0 23 24 0 18 25 0 24 25 0 19 26 0 25 26 0 20 27 0 26 27 0
		 27 21 0;
	setAttr -s 16 -ch 70 ".fc[0:15]" -type "polyFaces" 
		f 7 -7 -6 -5 -4 -3 -2 -1
		mu 0 7 7 13 12 11 10 9 8
		f 4 0 8 -10 -8
		mu 0 4 0 1 15 14
		f 4 1 10 -12 -9
		mu 0 4 1 2 16 15
		f 4 2 12 -14 -11
		mu 0 4 2 3 17 16
		f 4 3 14 -16 -13
		mu 0 4 3 4 18 17
		f 4 4 16 -18 -15
		mu 0 4 4 5 19 18
		f 4 5 18 -20 -17
		mu 0 4 5 6 20 19
		f 4 6 7 -21 -19
		mu 0 4 6 0 14 20
		f 7 21 22 23 24 25 26 27
		mu 0 7 21 27 26 25 24 23 22
		f 4 28 30 -30 -22
		mu 0 4 28 31 30 29
		f 4 29 32 -32 -23
		mu 0 4 29 30 33 32
		f 4 31 34 -34 -24
		mu 0 4 32 33 35 34
		f 4 33 36 -36 -25
		mu 0 4 34 35 37 36
		f 4 35 38 -38 -26
		mu 0 4 36 37 39 38
		f 4 37 40 -40 -27
		mu 0 4 38 39 41 40
		f 4 39 41 -29 -28
		mu 0 4 40 41 31 28;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode materialInfo -n "pasted__materialInfo1";
createNode shadingEngine -n "pasted__blinn1SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode blinn -n "pasted__blinn1";
	setAttr ".c" -type "float3" 0 0.83831668 1 ;
	setAttr ".ambc" -type "float3" 0 0.10723779 0.40700001 ;
createNode lightLinker -s -n "lightLinker1";
	setAttr -s 6 ".lnk";
	setAttr -s 6 ".slnk";
select -ne :time1;
	setAttr -av -k on ".cch";
	setAttr -cb on ".ihi";
	setAttr -k on ".nds";
	setAttr -cb on ".bnm";
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :renderPartition;
	setAttr -k on ".cch";
	setAttr -cb on ".ihi";
	setAttr -k on ".nds";
	setAttr -cb on ".bnm";
	setAttr -s 6 ".st";
	setAttr -cb on ".an";
	setAttr -cb on ".pt";
select -ne :initialShadingGroup;
	setAttr -k on ".cch";
	setAttr -cb on ".ihi";
	setAttr -av -k on ".nds";
	setAttr -cb on ".bnm";
	setAttr -s 2 ".dsm";
	setAttr -k on ".mwc";
	setAttr -cb on ".an";
	setAttr -cb on ".il";
	setAttr -cb on ".vo";
	setAttr -cb on ".eo";
	setAttr -cb on ".fo";
	setAttr -cb on ".epo";
	setAttr ".ro" yes;
	setAttr -cb on ".mimt";
	setAttr -cb on ".miop";
	setAttr -cb on ".mise";
	setAttr -cb on ".mism";
	setAttr -cb on ".mice";
	setAttr -av -cb on ".micc";
	setAttr -cb on ".mica";
	setAttr -cb on ".micw";
	setAttr -cb on ".mirw";
select -ne :initialParticleSE;
	setAttr -k on ".cch";
	setAttr -cb on ".ihi";
	setAttr -k on ".nds";
	setAttr -cb on ".bnm";
	setAttr -k on ".mwc";
	setAttr -cb on ".an";
	setAttr -cb on ".il";
	setAttr -cb on ".vo";
	setAttr -cb on ".eo";
	setAttr -cb on ".fo";
	setAttr -cb on ".epo";
	setAttr ".ro" yes;
	setAttr -cb on ".mimt";
	setAttr -cb on ".miop";
	setAttr -cb on ".mise";
	setAttr -cb on ".mism";
	setAttr -cb on ".mice";
	setAttr -cb on ".micc";
	setAttr -cb on ".mica";
	setAttr -cb on ".micw";
	setAttr -cb on ".mirw";
select -ne :defaultShaderList1;
	setAttr -k on ".cch";
	setAttr -cb on ".ihi";
	setAttr -k on ".nds";
	setAttr -cb on ".bnm";
	setAttr -s 6 ".s";
select -ne :defaultTextureList1;
	setAttr -s 7 ".tx";
select -ne :postProcessList1;
	setAttr -k on ".cch";
	setAttr -cb on ".ihi";
	setAttr -k on ".nds";
	setAttr -cb on ".bnm";
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
	setAttr -s 6 ".u";
select -ne :defaultRenderingList1;
select -ne :renderGlobalsList1;
	setAttr -k on ".cch";
	setAttr -cb on ".ihi";
	setAttr -k on ".nds";
	setAttr -cb on ".bnm";
select -ne :defaultResolution;
	setAttr -k on ".cch";
	setAttr -k on ".nds";
	setAttr -av ".w";
	setAttr -av ".h";
	setAttr ".pa" 1;
	setAttr -k on ".al";
	setAttr -av ".dar";
	setAttr -k on ".ldar";
	setAttr -k on ".off";
	setAttr -k on ".fld";
	setAttr -k on ".zsl";
select -ne :defaultLightSet;
	setAttr -k on ".cch";
	setAttr -k on ".ihi";
	setAttr -k on ".nds";
	setAttr -k on ".bnm";
	setAttr -k on ".mwc";
	setAttr -k on ".an";
	setAttr -k on ".il";
	setAttr -k on ".vo";
	setAttr -k on ".eo";
	setAttr -k on ".fo";
	setAttr -k on ".epo";
	setAttr ".ro" yes;
select -ne :defaultObjectSet;
	setAttr ".ro" yes;
select -ne :hardwareRenderGlobals;
	setAttr -k on ".cch";
	setAttr -cb on ".ihi";
	setAttr -k on ".nds";
	setAttr -cb on ".bnm";
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
	setAttr -k off -cb on ".ehql";
	setAttr -k off -cb on ".eams";
	setAttr -k off -cb on ".eeaa";
	setAttr -k off -cb on ".engm";
	setAttr -k off -cb on ".mes";
	setAttr -k off -cb on ".emb";
	setAttr -k off -cb on ".mbbf";
	setAttr -k off -cb on ".mbs";
	setAttr -k off -cb on ".trm";
	setAttr -k off -cb on ".tshc";
	setAttr -k off -cb on ".clmt";
	setAttr -k off -cb on ".tcov";
	setAttr -k off -cb on ".lith";
	setAttr -k off -cb on ".sobc";
	setAttr -k off -cb on ".cuth";
	setAttr -k off -cb on ".mgcs";
	setAttr -k off -cb on ".twa";
	setAttr -k off -cb on ".twz";
	setAttr -k on ".hwcc";
	setAttr -k on ".hwdp";
	setAttr -k on ".hwql";
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 18 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surfaces" "Particles" "Fluids" "Image Planes" "UI:" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 18 0 1 1 1 1 1
		 1 0 0 0 0 0 0 0 0 0 0 0 ;
select -ne :defaultHardwareRenderGlobals;
	setAttr -k on ".cch";
	setAttr -cb on ".ihi";
	setAttr -k on ".nds";
	setAttr -cb on ".bnm";
	setAttr -k on ".rp";
	setAttr -k on ".cai";
	setAttr -k on ".coi";
	setAttr -cb on ".bc";
	setAttr -av -k on ".bcb";
	setAttr -av -k on ".bcg";
	setAttr -av -k on ".bcr";
	setAttr -k on ".ei";
	setAttr -k on ".ex";
	setAttr -av -k on ".es";
	setAttr -av -k on ".ef";
	setAttr -av -k on ".bf";
	setAttr -k on ".fii";
	setAttr -av -k on ".sf";
	setAttr -k on ".gr";
	setAttr -k on ".li";
	setAttr -k on ".ls";
	setAttr -k on ".mb";
	setAttr -k on ".ti";
	setAttr -k on ".txt";
	setAttr -k on ".mpr";
	setAttr -k on ".wzd";
	setAttr ".fn" -type "string" "im";
	setAttr -k on ".if";
	setAttr ".res" -type "string" "ntsc_4d 646 485 1.333";
	setAttr -k on ".as";
	setAttr -k on ".ds";
	setAttr -k on ".lm";
	setAttr -k on ".fir";
	setAttr -k on ".aap";
	setAttr -k on ".gh";
	setAttr -cb on ".sd";
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "pasted__blinn1SG.msg" "pasted__materialInfo1.sg";
connectAttr "pasted__blinn1.msg" "pasted__materialInfo1.m";
connectAttr "pasted__blinn1.oc" "pasted__blinn1SG.ss";
connectAttr "crystalCollectibleShape.iog" "pasted__blinn1SG.dsm" -na;
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "pasted__blinn1SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "pasted__blinn1SG.message" ":defaultLightSet.message";
connectAttr "pasted__blinn1SG.pa" ":renderPartition.st" -na;
connectAttr "pasted__blinn1.msg" ":defaultShaderList1.s" -na;
// End of crystalCollectible.ma
