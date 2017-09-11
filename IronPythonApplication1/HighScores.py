import sys
sys.path.append(r"C:\Program Files (x86)\IronPython 2.7\Lib")
import clr
import os
import pickle
clr.AddReference('System.Windows.Forms')
from operator import itemgetter


def makeHSTable(name, score):
    highScoresFilename = 'highScores.dat'
    emptyTuple= None, 0
    scores = []
   
   # To get empty list with zero scores in new .dat file
    for x in range(10):
        scores.append(emptyTuple)

    # checks if file to save scores exists, if not, creates one filled with 0s
    if os.path.exists(highScoresFilename):
        with open(highScoresFilename,'rb') as rs: 
            scores = pickle.load(rs)

    highScore = name, score
    scores.append(highScore)
            
    # update score table
    with open(highScoresFilename,'wb') as ws:
        pickle.dump(scores, ws)
               
    # re-open score table and sort so that highest score is first, only 10 entries
    with open(highScoresFilename,'rb') as rs:
       scores = pickle.load(rs)
       scores = sorted(scores, key=itemgetter(1), reverse=True)[:10]

    return scores

#pickle - modul for import data into files and export from them)

#FOR TESTING PURPOSES
#print(makeHSTable("genericName", 5))
#raw_input()
       