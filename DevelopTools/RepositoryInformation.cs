using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopTools
{
    public class RepositoryInformation : IDisposable
    {
        private bool _disposed;
        private readonly Repository _repo;

        public static RepositoryInformation GetRepositoryInformationForPath(string path)
        {
            if (LibGit2Sharp.Repository.IsValid(path))
            {
                return new RepositoryInformation(path);
            }
            return null;
        }

        public string CommitHash
        {
            get
            {
                return _repo.Head.Tip.Sha;
            }
        }

        public string BranchName
        {
            get
            {
                return _repo.Head.FriendlyName;// .Name;
            }
        }

        public string TrackedBranchName
        {
            get
            {
                return _repo.Head.IsTracking ? _repo.Head.TrackedBranch.CanonicalName : String.Empty;
            }
        }

        public bool HasUnpushedCommits
        {
            get
            {
                return _repo.Head.TrackingDetails.AheadBy > 0;
            }
        }

        public bool HasUncommittedChanges
        {
            get
            {
                var algo = _repo.RetrieveStatus();
                return _repo.RetrieveStatus().Any(s => s.State != FileStatus.Ignored);

            }
        }

        public void CommitChangesAllChanges(string Message)
        {
            try
            {
                if(HasUncommittedChanges)
                {
                    Commands.Stage(_repo, "*");//agrega todos los cambios

                    Signature author = new Signature(new Identity("jose.carrillo", "jose.carrillo@blueoceantech.com.mx"), DateTime.Now);
                    var commitResponse = _repo.Commit("Integración de ramas", author, author);
                    
                }
                else
                {
                    //Nada a que hacer commmit
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            
        }

        public void PullFromOrigin()
        {
            LibGit2Sharp.PullOptions options= new PullOptions();
            options.FetchOptions = new FetchOptions();
            options.FetchOptions.CredentialsProvider = new CredentialsHandler(
            (url, usernameFromUrl, types) =>
                new UsernamePasswordCredentials()
                {
                    Username = "",
                    Password = ""
                });
            
            // User information to create a merge commit
            var signature = new LibGit2Sharp.Signature(
                new Identity("MERGE_USER_NAME", "MERGE_USER_EMAIL"), DateTimeOffset.Now);

            // Pull
            Commands.Pull(_repo, signature, options);
            
        }

        public IEnumerable<Commit> Log
        {
            get
            {
                return _repo.Head.Commits;
            }
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _disposed = true;
                _repo.Dispose();
            }
        }

        private RepositoryInformation(string path)
        {
            _repo = new Repository(path);
        }


    }
}
